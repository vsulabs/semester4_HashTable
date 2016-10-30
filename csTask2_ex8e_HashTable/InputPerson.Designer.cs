namespace csTask2_ex8e_HashTable
{
    partial class InputPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPerson));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbNumOfDoc = new System.Windows.Forms.TextBox();
            this.tbSeriesOfDoc = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNubmerSeries = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(58, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Changeble";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(71, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(225, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(71, 45);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(279, 20);
            this.tbFullName.TabIndex = 3;
            this.tbFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFullName_KeyPress);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(71, 87);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(279, 20);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // tbNumOfDoc
            // 
            this.tbNumOfDoc.Location = new System.Drawing.Point(71, 139);
            this.tbNumOfDoc.MaxLength = 4;
            this.tbNumOfDoc.Name = "tbNumOfDoc";
            this.tbNumOfDoc.Size = new System.Drawing.Size(52, 20);
            this.tbNumOfDoc.TabIndex = 5;
            this.tbNumOfDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumOfDoc_KeyPress);
            // 
            // tbSeriesOfDoc
            // 
            this.tbSeriesOfDoc.Location = new System.Drawing.Point(225, 139);
            this.tbSeriesOfDoc.MaxLength = 6;
            this.tbSeriesOfDoc.Name = "tbSeriesOfDoc";
            this.tbSeriesOfDoc.Size = new System.Drawing.Size(125, 20);
            this.tbSeriesOfDoc.TabIndex = 6;
            this.tbSeriesOfDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeriesOfDoc_KeyPress);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(11, 48);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // lblNubmerSeries
            // 
            this.lblNubmerSeries.AutoSize = true;
            this.lblNubmerSeries.Location = new System.Drawing.Point(12, 122);
            this.lblNubmerSeries.Name = "lblNubmerSeries";
            this.lblNubmerSeries.Size = new System.Drawing.Size(51, 13);
            this.lblNubmerSeries.TabIndex = 9;
            this.lblNubmerSeries.Text = "Passport:";
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(180, 142);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(39, 13);
            this.lblSeries.TabIndex = 10;
            this.lblSeries.Text = "Series:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "№";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblQuestion.Location = new System.Drawing.Point(356, 90);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(13, 13);
            this.lblQuestion.TabIndex = 12;
            this.lblQuestion.Text = "?";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // InputPerson
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(383, 200);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.lblNubmerSeries);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.tbSeriesOfDoc);
            this.Controls.Add(this.tbNumOfDoc);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputPerson";
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbNumOfDoc;
        private System.Windows.Forms.TextBox tbSeriesOfDoc;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNubmerSeries;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
    }
}