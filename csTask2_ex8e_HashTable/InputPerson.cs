using System;
using System.Windows.Forms;

namespace csTask2_ex8e_HashTable
{
    public partial class InputPerson : Form
    {
        private string _innerFullName = string.Empty;
        private string _innerAddress = string.Empty;
        private string _innerSeries = string.Empty;
        private string _innerNum = string.Empty;
        public string GetPerson { get { return ConcatPersonInfo(); } }
        
        public int GetDocNum { get { return DocNum(); } }
        public int GetDocSeries { get { return DocSeries(); } }

        private bool _isOkData;
        private readonly bool _onlyDocsData;

        public InputPerson(TaskQuery messageHeader) {
            InitializeComponent();
            switch (messageHeader) { 
                case TaskQuery.Search:
                    lblInfo.Text = @"Поиск по паспортным данным";
                    break;
                case TaskQuery.Add:
                    lblInfo.Text = @"Добавление";
                    break;
                case TaskQuery.Delete:
                    lblInfo.Text = @"Удаление";
                    break;
            }
            if (messageHeader != TaskQuery.Add) {
                tbAddress.Enabled = tbFullName.Enabled = false;
                lblQuestion.Enabled = false;
            }
            _onlyDocsData = messageHeader != TaskQuery.Add;

        }

        private void lblQuestion_Click(object sender, EventArgs e) {
            MessageBox.Show(@"Адрес вводится без использования символов "":"" или "","" "  + 
                            @"Разделителем служит только точка");
        }

        private void btnOk_Click(object sender, EventArgs e) {
            int tmpSer, tmpNum;
            if (_onlyDocsData)
                _isOkData = //tbNumOfDoc.Text.Length == tbNumOfDoc.MaxLength &&
                            //tbSeriesOfDoc.Text.Length == tbSeriesOfDoc.MaxLength &&
                            Int32.TryParse(tbNumOfDoc.Text.Trim(), out tmpNum) &&
                            Int32.TryParse(tbSeriesOfDoc.Text.Trim(), out tmpSer) &&
                            (tmpNum < 10000) && (tmpSer < 1000000);
            else
                _isOkData = //tbNumOfDoc.Text.Length == tbNumOfDoc.MaxLength &&
                            //tbSeriesOfDoc.Text.Length == tbSeriesOfDoc.MaxLength && 
                            (tbAddress.Text.Trim() != string.Empty) && (tbFullName.Text.Trim() != string.Empty) &&
                            Int32.TryParse(tbNumOfDoc.Text.Trim(), out tmpNum) &&
                            Int32.TryParse(tbSeriesOfDoc.Text.Trim(), out tmpSer) &&
                            (tmpNum < 10000) && (tmpSer < 1000000);
            if (!_isOkData)
            {
                MessageBox.Show(@"Данные введены неверно: все доступные для ввода поля должны быть заполнены, номер паспорта должен состоять из 4 символов, а серия из 6");
                btnOk.Focus();
                return;
            }
            
            _innerAddress = tbAddress.Text.Trim();
            _innerFullName = tbFullName.Text.Trim();
            _innerNum = tbNumOfDoc.Text.Trim();
            _innerSeries = tbSeriesOfDoc.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private int DocSeries() {
            if (!_isOkData)
                return 0;
            return Int32.Parse(_innerSeries);
        }
        private int DocNum()
        {
            if (!_isOkData)
                return 0;
            
            return Int32.Parse(_innerNum);
        }
        private string ConcatPersonInfo() {
            if (_isOkData)
                return "FullName: " + _innerFullName + ", Address: " + _innerAddress + ", Passport data: " + _innerNum + " " + _innerSeries;
            
            return string.Empty;
        }

        private void MyFilterDoc(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
              
        private void tbNumOfDoc_KeyPress(object sender, KeyPressEventArgs e) {
            MyFilterDoc(e);
        }
        

        private void tbSeriesOfDoc_KeyPress(object sender, KeyPressEventArgs e) {
            MyFilterDoc(e);
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' &&
                e.KeyChar != '.' && !(e.KeyChar >= 'a' && e.KeyChar <= 'z') && !(e.KeyChar >= 'а' && e.KeyChar <= 'я') &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'А' && e.KeyChar <= 'Я')
                )
                e.Handled = true;
        }
        
        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != ' ' &&
                e.KeyChar != '.' && !(e.KeyChar >= 'a' && e.KeyChar <= 'z') && !(e.KeyChar >= 'а' && e.KeyChar <= 'я') &&
                !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'А' && e.KeyChar <= 'Я'))

                e.Handled = true;
        }

      
        
    }
}
