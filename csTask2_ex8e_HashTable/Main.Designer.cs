namespace csTask2_ex8e_HashTable
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.fdOpen = new System.Windows.Forms.OpenFileDialog();
            this.fdSave = new System.Windows.Forms.SaveFileDialog();
            this.tsMenu = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCondition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsActions = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRun = new System.Windows.Forms.ToolStripButton();
            this.tsbCondition = new System.Windows.Forms.ToolStripButton();
            this.pnlGredView = new System.Windows.Forms.Panel();
            this.gvHash = new System.Windows.Forms.DataGridView();
            this.tsMenu.SuspendLayout();
            this.tsActions.SuspendLayout();
            this.pnlGredView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHash)).BeginInit();
            this.SuspendLayout();
            // 
            // fdOpen
            // 
            this.fdOpen.Filter = "Text files (*.txt) | *.txt";
            this.fdOpen.Title = "Open file ...";
            // 
            // fdSave
            // 
            this.fdSave.Filter = "Text files (*.txt) | *.txt";
            this.fdSave.Title = "Save as ...";
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsEdit,
            this.tsTask});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(506, 24);
            this.tsMenu.TabIndex = 2;
            this.tsMenu.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.tsmOpenFile,
            this.tsmSave,
            this.tsmSaveAs,
            this.tsmCloseFile,
            this.toolStripSeparator2,
            this.tsmExitProgram});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(40, 20);
            this.tsFile.Text = "FILE";
            // 
            // tsmNew
            // 
            this.tsmNew.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_5306;
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmNew.Size = new System.Drawing.Size(195, 22);
            this.tsmNew.Text = "New";
            this.tsmNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // tsmOpenFile
            // 
            this.tsmOpenFile.Image = global::csTask2_ex8e_HashTable.Properties.Resources.open;
            this.tsmOpenFile.Name = "tsmOpenFile";
            this.tsmOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmOpenFile.Size = new System.Drawing.Size(195, 22);
            this.tsmOpenFile.Text = "Open";
            this.tsmOpenFile.Click += new System.EventHandler(this.tsmOpenFile_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Image = global::csTask2_ex8e_HashTable.Properties.Resources.save;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmSave.Size = new System.Drawing.Size(195, 22);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Image = global::csTask2_ex8e_HashTable.Properties.Resources.save_as;
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmSaveAs.Size = new System.Drawing.Size(195, 22);
            this.tsmSaveAs.Text = "Save As...";
            this.tsmSaveAs.Click += new System.EventHandler(this.tsmSaveAs_Click);
            // 
            // tsmCloseFile
            // 
            this.tsmCloseFile.Image = global::csTask2_ex8e_HashTable.Properties.Resources.close;
            this.tsmCloseFile.Name = "tsmCloseFile";
            this.tsmCloseFile.Size = new System.Drawing.Size(195, 22);
            this.tsmCloseFile.Text = "Close";
            this.tsmCloseFile.Click += new System.EventHandler(this.tsmCloseFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // tsmExitProgram
            // 
            this.tsmExitProgram.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_5102;
            this.tsmExitProgram.Name = "tsmExitProgram";
            this.tsmExitProgram.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmExitProgram.Size = new System.Drawing.Size(195, 22);
            this.tsmExitProgram.Text = "Exit";
            this.tsmExitProgram.Click += new System.EventHandler(this.tsmExitProgram_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmDelete,
            this.toolStripSeparator4,
            this.tsmClear});
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(43, 20);
            this.tsEdit.Text = "EDIT";
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_5338;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmAdd.Size = new System.Drawing.Size(138, 22);
            this.tsmAdd.Text = "Add";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::csTask2_ex8e_HashTable.Properties.Resources.delete;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(138, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(138, 22);
            this.tsmClear.Text = "Clear";
            this.tsmClear.Click += new System.EventHandler(this.tsmClear_Click);
            // 
            // tsTask
            // 
            this.tsTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRun,
            this.toolStripSeparator1,
            this.tsmCondition});
            this.tsTask.Name = "tsTask";
            this.tsTask.Size = new System.Drawing.Size(47, 20);
            this.tsTask.Text = "TASK";
            // 
            // tsmRun
            // 
            this.tsmRun.Image = global::csTask2_ex8e_HashTable.Properties.Resources.task;
            this.tsmRun.Name = "tsmRun";
            this.tsmRun.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tsmRun.Size = new System.Drawing.Size(146, 22);
            this.tsmRun.Text = "Run";
            this.tsmRun.Click += new System.EventHandler(this.tsmRun_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // tsmCondition
            // 
            this.tsmCondition.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_81;
            this.tsmCondition.Name = "tsmCondition";
            this.tsmCondition.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmCondition.Size = new System.Drawing.Size(146, 22);
            this.tsmCondition.Text = "Condition";
            this.tsmCondition.Click += new System.EventHandler(this.tsmCondition_Click);
            // 
            // tsActions
            // 
            this.tsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator5,
            this.tsbAdd,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbRun,
            this.tsbCondition});
            this.tsActions.Location = new System.Drawing.Point(0, 24);
            this.tsActions.Name = "tsActions";
            this.tsActions.Size = new System.Drawing.Size(506, 25);
            this.tsActions.TabIndex = 3;
            this.tsActions.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_5306;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::csTask2_ex8e_HashTable.Properties.Resources.open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "Open file";
            this.tsbOpen.Click += new System.EventHandler(this.tsmOpenFile_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::csTask2_ex8e_HashTable.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_5338;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::csTask2_ex8e_HashTable.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRun
            // 
            this.tsbRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRun.Image = global::csTask2_ex8e_HashTable.Properties.Resources.task;
            this.tsbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRun.Name = "tsbRun";
            this.tsbRun.Size = new System.Drawing.Size(23, 22);
            this.tsbRun.Text = "Run";
            this.tsbRun.Click += new System.EventHandler(this.tsmRun_Click);
            // 
            // tsbCondition
            // 
            this.tsbCondition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCondition.Image = global::csTask2_ex8e_HashTable.Properties.Resources.imageres_81;
            this.tsbCondition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCondition.Name = "tsbCondition";
            this.tsbCondition.Size = new System.Drawing.Size(23, 22);
            this.tsbCondition.Text = "Condition";
            this.tsbCondition.Click += new System.EventHandler(this.tsmCondition_Click);
            // 
            // pnlGredView
            // 
            this.pnlGredView.Controls.Add(this.gvHash);
            this.pnlGredView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGredView.Location = new System.Drawing.Point(0, 49);
            this.pnlGredView.Name = "pnlGredView";
            this.pnlGredView.Size = new System.Drawing.Size(506, 359);
            this.pnlGredView.TabIndex = 4;
            // 
            // gvHash
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gvHash.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvHash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHash.Location = new System.Drawing.Point(-6, 17);
            this.gvHash.Name = "gvHash";
            this.gvHash.ReadOnly = true;
            this.gvHash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvHash.Size = new System.Drawing.Size(506, 318);
            this.gvHash.TabIndex = 1;
            this.gvHash.SizeChanged += new System.EventHandler(this.gvHash_SizeChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 408);
            this.Controls.Add(this.pnlGredView);
            this.Controls.Add(this.tsActions);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.tsMenu;
            this.Name = "FrmMain";
            this.Text = "Задание 2 номер 8е";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tsActions.ResumeLayout(false);
            this.tsActions.PerformLayout();
            this.pnlGredView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fdOpen;
        private System.Windows.Forms.SaveFileDialog fdSave;
        private System.Windows.Forms.MenuStrip tsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsmCloseFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmExitProgram;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsTask;
        private System.Windows.Forms.ToolStripMenuItem tsmRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCondition;
        private System.Windows.Forms.ToolStrip tsActions;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRun;
        private System.Windows.Forms.ToolStripButton tsbCondition;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Panel pnlGredView;
        internal System.Windows.Forms.DataGridView gvHash;
    }
}

