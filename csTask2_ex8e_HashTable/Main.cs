using System;
using System.Windows.Forms;
using System.IO;


/*
 * задан набор записей следующей структуры: паспортные данные (запись), ФИО владельца, адрес прописки.
 * По паспортным данным определить ФИО владельца и адрес.
 */
namespace csTask2_ex8e_HashTable
{
    public enum TaskQuery {
        Add,
        Search,
        Delete,
    }
    public partial class FrmMain : Form
    {
        private HashGui _table;
        public FrmMain() {
            InitializeComponent();

            fdSave.InitialDirectory = Directory.GetCurrentDirectory();
            fdOpen.InitialDirectory = Directory.GetCurrentDirectory();

            Application.Idle += VisibleElems;
        }

        private void tsmNew_Click(object sender, EventArgs e) {
            if (CanClose(_table, sender, e))
                _table = new HashGui(gvHash);
        }

        private void tsmOpenFile_Click(object sender, EventArgs e) {
            if (fdOpen.ShowDialog() == DialogResult.OK && CanClose(_table, sender, e)) {
                _table = new HashGui(gvHash);
                if (!_table.LoadFromFile(fdOpen.FileName)) {
                    _table = null;
                    MessageBox.Show(@"Данные не смогли быть загружены");
                }
            }
        }

        private void tsmSave_Click(object sender, EventArgs e) {
            if (_table.FileName == string.Empty)
                tsmSaveAs_Click(sender, e);
            else
                _table.SaveToFile(_table.FileName);
        }

        private void tsmSaveAs_Click(object sender, EventArgs e) {
            fdSave.FileName = _table.FileName;
            if (fdSave.ShowDialog() == DialogResult.OK)
                _table.SaveToFile(fdSave.FileName);
        }

        private void tsmCloseFile_Click(object sender, EventArgs e) {
            if (CanClose(_table, sender, e)) // проверка, были ли изменения и диалог о необходимости их сохранения
                _table = null;
        }

        private void tsmExitProgram_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsmAdd_Click(object sender, EventArgs e) {
            InputPerson dialog = new InputPerson(TaskQuery.Add);
            if (dialog.ShowDialog()== DialogResult.OK) {
                Person newPerson = new Person();
                if (HashUtils.FillPerson(dialog.GetPerson, ref newPerson) && !_table.Add(newPerson))
                    MessageBox.Show(@"Данные не были добавлены");
            }
        }
        
        private void tsmDelete_Click(object sender, EventArgs e) {
            InputPerson dialog = new InputPerson(TaskQuery.Delete);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK) {
                Person p = new Person(n: dialog.GetDocNum, s: dialog.GetDocSeries);
                if (!_table.Delete(p.Passport))
                    MessageBox.Show(@"удаление не произведено");
            }
        }

        private void tsmClear_Click(object sender, EventArgs e) {
            if (MessageBox.Show(@"Вы уверены, что хотите удалить данные?", @"Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                _table.Clear();
        }

        private void tsmRun_Click(object sender, EventArgs e) {
            InputPerson dialog = new InputPerson(TaskQuery.Search);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK) {
                Person p = new Person(n: dialog.GetDocNum, s: dialog.GetDocSeries);
                Person res = new Person();
                if (_table.Find(p.Passport, ref res)) {
                    string tmp = res.FullName + ", адрес: " + res.Address;
                    MessageBox.Show(@"По паспортным данным найден:" + tmp);
                }
                else
                    MessageBox.Show(@"По паспортным данным никто не найден");
            }
        }

        private void tsmCondition_Click(object sender, EventArgs e) {
            MessageBox.Show(@"Задан набор записей следующей структуры: паспортные данные (запись), ФИО владельца, адрес прописки. "+
                            @"По паспортным данным определить ФИО владельца и адрес.");
        }

        /// <summary> функция проверяет, были ли модифицированы данные в структуре данных.
        /// Если данные были изменены, появляется диалоговое окно, в котором можно 
        /// подтвердить сохранение данных
        /// </summary>
        /// <param name="table"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool CanClose(HashGui table, object sender, EventArgs e) {
            if (table != null && table.Modified) {
                DialogResult dl = MessageBox.Show(@"Хотите ли вы сохранить данные в файл?", @"Внимание", MessageBoxButtons.YesNoCancel);
                if (dl == DialogResult.Yes) {
                    tsmSave_Click(sender, e);
                    return !table.Modified;
                }
                if (dl == DialogResult.No)
                    return true;
                return false;
            }
            return true;
        } 

        /// <summary> в зависимости от состояния хранимой структуры регулирует
        /// видимость или доступность элементов управления формы
        /// </summary>
        private void VisibleElems(object sender, EventArgs e) {            
            gvHash.Visible = _table != null;
            
            tsmAdd.Enabled = tsbAdd.Enabled = _table != null;
                tsmDelete.Enabled = tsbDelete.Enabled =
                tsmRun.Enabled = tsbRun.Enabled =
                tsmClear.Enabled = (_table != null && _table.Count != 0);

            tsmSave.Enabled = tsbSave.Enabled =
                tsmSaveAs.Enabled = tsmCloseFile.Enabled = (_table != null);
        } // ... VisibleElems

        /// <summary> событие при попытке закрыть форму без сохранения данных:
        /// появится диалоговое окно с предложением сохранить изменения в файл
        /// </summary>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !CanClose(_table, sender, e);
        }

        private void gvHash_SizeChanged(object sender, EventArgs e) {
            HashUtils.CalcSize(gvHash);
        } 

    }
}
