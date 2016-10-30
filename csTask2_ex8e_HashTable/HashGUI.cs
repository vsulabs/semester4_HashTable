using System.IO;
using System.Windows.Forms;

namespace csTask2_ex8e_HashTable
{
    public class HashGui : HashTable
    {
        private string _fileName;
        private bool _modified;
        private readonly DataGridView _grid;

        public HashGui(DataGridView gv)
        {
            _grid = gv;
            _modified = false;
            _fileName = "";
            PrintToGrid();
        } // constructor HashGUI
        public HashGui(DataGridView gv, string name)
        {
            _modified = false;
            _fileName = name;
            _grid = gv;
            if (!LoadFromFile(_fileName))
                throw new FileLoadException("не удалось загрузить данные из файла");
        } // constructor HashGUI

        public void PrintToGrid()
        {
            base.PrintToGrid(_grid);
        }
        public new bool Add(Person person)
        {
            if (base.Add(person))
            {
                Mod = true;
                return true;
            }
            return false;
        }
        public new bool Delete(Document passport)
        {
            if (base.Delete(passport))
            {
                Mod = true;
                return true;
            }
            return false;
        }

        public new void SaveToFile(string name)
        {
            _fileName = name;
            base.SaveToFile(name);
            _modified = false;
        }
        public new bool LoadFromFile(string name)
        {
            _fileName = name;
            bool res = base.LoadFromFile(_fileName);
            Mod = false;
            return res;
        }

        public bool Modified => _modified;
        private bool Mod { set { _modified = value; PrintToGrid(); } }
        public string FileName => _fileName;
    } // class HashGUI
}
