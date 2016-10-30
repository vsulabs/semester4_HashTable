using System;
using System.Windows.Forms;
using System.IO;

/*
 * задан набор записей следующей структуры: паспортные данные (запись), ФИО владельца, адрес прописки.
 * По паспортным данным определить ФИО владельца и адрес.
 */
namespace csTask2_ex8e_HashTable
{
    public struct Document {
        public int Num;
        public int Series;
        public Document(int n = 0, int s = 0) {
            Num = n;
            Series = s;
        } // counstructor Document
    } // struct Document

    public struct Person {
        public string FullName;
        public string Address;
        public Document Passport;
        public Person(string f = "", string a = "", int n = 0, int s = 0) {
            FullName = f;
            Address = a;
            Passport = new Document(n, s);
        } // constructor Person
        public static int HashF_a0(Document key)
        {
            return key.Num + key.Series;
        }
        public static int HashF_c(Document key)
        {
            return key.Series % 20;
        }
    } // struct Person

    public class HashTable
    {
        private enum CellState {
            Free,
            Full,
            Del
        };

        private struct Cell {
            public Person Info;
            public CellState State;
        }

        const int N = 997;
        private Cell[] _table;
        private int _count;

        int HashFunc_a0(Document key) {
            return Person.HashF_a0(key) % N;
        } // ...HashFunc_a0
        int HashFunc_c(Document key) {
            return Person.HashF_c(key) % N;
        } // ...HashFunc_c
        int NextCell(int a0, int c, ref int i) {
            ++i;
            return (a0 + c * i) % N;
        } // ...NextCell
        int IndexOf(Document key) {
            int a0 = HashFunc_a0(key);
            int c = HashFunc_c(key);
            int a = a0;

            int i = 0;
            bool stop = false;
            bool found = false;
            do {
                switch (_table[a].State) {
                    case CellState.Free:
                        stop = true;
                        break;
                    case CellState.Del:
                        a = NextCell(a0, c, ref i);
                        break;
                    case CellState.Full:
                        if (IsEqualKey(key, _table[a].Info.Passport))
                            found = true;
                        else
                            a = NextCell(a0, c, ref i);
                        break;
                } // switch...
            } while (!stop && !found && (i != N * 2));
            if (found)
                return a;
            else
                return -1;
        } // ...IndexOf

        public HashTable() {
            _table = new Cell[N];
            Clear();
        } // constructor HashTable
        public void Clear() {
            _count = 0;
            for (int i = 0; i < N; ++i) 
                _table[i].State = CellState.Free;
        } // ...Clear
        public bool Add(Person info) {
            int a0 = HashFunc_a0(info.Passport);
            int c = HashFunc_c(info.Passport);
            int i = 0;
            int a = a0;
            bool stop = false;
            bool found = false;
            int d = -1;
            if (_count < N) {
                do {
                    switch (_table[a].State) {
                        case CellState.Full:
                            if (IsEqualKey(info.Passport, _table[a].Info.Passport))
                                found = true;
                            else
                                a = NextCell(a0, c, ref i);
                            break;
                        case CellState.Del:
                            if (d == -1)
                                d = a;
                            a = NextCell(a0, c, ref i);
                            break;
                        case CellState.Free:
                            stop = true;
                            break;
                    } // switch...
                } while ( !stop && !found && (i != N));

                if (stop) {
                    if (d != -1)
                        a = d;
                    _table[a].Info = info;
                    _table[a].State = CellState.Full;
                    _count++;
                    return true;
                } // if (stop) ...
                return false;
            } // if (count < N) ...
            return false;
        } // ...Add
        public bool Find(Document key, ref Person info) {
            int a = IndexOf(key);
            if (a >= 0) {
                info = _table[a].Info;
                return true;
            }
            return false;
        } // ...Find
        public bool Delete(Document key) {
            int a = IndexOf(key);
            if (a >= 0) {
                _table[a].State = CellState.Del;
                _count--;
                return true;
            }
            return false;
        } // ...Delete

        public void SaveToFile(string fileName) {
            StreamWriter sw = new StreamWriter(fileName);
            for (int i = 0; i < N; i++)
                if (_table[i].State == CellState.Full)
                    sw.WriteLine(HashUtils.StateToString(_table[i].Info));
            sw.Close();
        } // ...SaveToFile
        public bool LoadFromFile(string fileName) {
            StreamReader sr = new StreamReader(fileName);
            _table = new Cell[N];
            bool res = true;

            while (sr.Peek() >= 0 && res) {
                string readLine = sr.ReadLine();
                if (readLine != null) {
                    readLine = readLine.ToLower().Trim();
                    Person person = new Person();
                    res = HashUtils.FillPerson(readLine, ref person);
                    if (res)
                        Add(person);
                }
            } // while ...

            if (!res)
                Clear();
            sr.Close();
            return res;
        } // ...LoadFromFile
        public void PrintToGrid(DataGridView grid) {
            grid.ColumnCount = 4;
            if (_count == 0) {
                grid.RowCount = 2;                
                grid.Rows[1].Cells[0].Value = grid.Rows[1].Cells[1].Value = 
                    grid.Rows[1].Cells[2].Value = grid.Rows[1].Cells[3].Value = "";
            } 
            else 
                grid.RowCount = _count + 1;
            HashUtils.ShowTitle(grid);
            int j = 0;
            if (_count > 0) {
                for (int i = 0; i < N - 1; ++i)
                    if (_table[i].State == CellState.Full) {
                        ++j;
                        HashUtils.ShowInfo(j, _table[i].Info, grid.Rows[j]);
                    } // if (table.state = full) ...
            } // if (count > 0) ...
        } // ...PrintToGrid
        
        static bool IsEqualKey(Document keyOne, Document keyTwo) {
            return (keyOne.Num == keyTwo.Num) && (keyOne.Series == keyTwo.Series);
        } // ... isEqualKey
        
        public int Count => _count;
    } // class HashTable

    class HashUtils {
        public static void ShowTitle(DataGridView gv) {
            gv.ColumnCount = 4;
            CalcSize(gv);
            gv.Rows[0].Cells[0].Value = "№";
            gv.Rows[0].Cells[1].Value = "Passport";
            gv.Rows[0].Cells[2].Value = "Full name";
            gv.Rows[0].Cells[3].Value = "Address";
        } // ...ShowTitle

        public static void ShowInfo(int n, Person info, DataGridViewRow row) {
            row.Cells[0].Value = n.ToString();

            string strNum = info.Passport.Num.ToString();
            int diff = 4 - strNum.Length;
            for (int i = 0; i < diff; ++i)
                strNum = "0" + strNum;
            string strSer = info.Passport.Series.ToString();
            diff = 6 - strSer.Length;
            for (int i = 0; i < diff; ++i)
                strSer = "0" + strSer;
            row.Cells[1].Value = strNum + " " + strSer;
            //row.Cells[1].Value = info.Passport.Num.ToString() + " " + info.Passport.Series.ToString();
            row.Cells[2].Value = info.FullName;
            row.Cells[3].Value = info.Address;
        } // ...ShowInfo

        public static void CalcSize(DataGridView gv) {
            if (gv.ColumnCount != 0)
            {
                gv.Columns[0].Width = gv.Width / 16;
                gv.Columns[1].Width = gv.Columns[2].Width = gv.Columns[3].Width = gv.Columns[0].Width * 5;
                gv.Height = (gv.Rows.Count + 1) * gv.Rows[0].Height;
            }
        } // ...CalcSize

        public static string StateToString(Person person) {
            return
                "FullName: " + person.FullName + ", " +
                "Address: " + person.Address + ", " +
                "Passport data: " + person.Passport.Num.ToString() +
                " " + person.Passport.Series.ToString();
        } // ...StateToString

        public static bool FillPerson(string information, ref Person res) {
            string[] fields = information.Split(',');
            if (fields.Length != 3)
                return false;
            res.FullName = fields[0].Substring(fields[0].IndexOf(':') + 1);
            res.Address = fields[1].Substring(fields[1].IndexOf(':') + 1);
            fields = fields[2].Substring(fields[2].IndexOf(':') + 2).Split(' ');
            if (fields.Length != 2)
                return false;
            res.Passport.Num = Convert.ToInt32(fields[0]);
            res.Passport.Series = Convert.ToInt32(fields[1]);
            if (res.Address == string.Empty || res.FullName == string.Empty ||
                res.Passport.Num > 9999 ||
                res.Passport.Series > 999999)
                return false;
            return true;
        } // ...FillPerson
        
    } // class HashUtils    
} // namespace csTask2_ex8e_HashTable
