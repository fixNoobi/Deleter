namespace Deleter
{
    partial class dForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dForm));
            this.findListView = new System.Windows.Forms.ListView();
            this.MainListViewIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainListViewNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainListViewFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainListViewFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainListViewNameEst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuDataGetData = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainButFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButLog = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButLogSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainButLogClear = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelInfoFile = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelFileExt = new System.Windows.Forms.Label();
            this.LabelFileDataChange = new System.Windows.Forms.Label();
            this.LabelFileSize = new System.Windows.Forms.Label();
            this.LabelFileDataCreate = new System.Windows.Forms.Label();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.tFileChange = new System.Windows.Forms.TextBox();
            this.tFileMask = new System.Windows.Forms.TextBox();
            this.tFileCreate = new System.Windows.Forms.TextBox();
            this.tFileSize = new System.Windows.Forms.TextBox();
            this.tFileName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.findMask = new System.Windows.Forms.ToolStripComboBox();
            this.findPath = new System.Windows.Forms.ToolStripTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ContextMenuDataOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.findButFind = new System.Windows.Forms.ToolStripButton();
            this.findButDelete = new System.Windows.Forms.ToolStripButton();
            this.findButClear = new System.Windows.Forms.ToolStripButton();
            this.findButCheckAll = new System.Windows.Forms.ToolStripButton();
            this.findButOpenAs = new System.Windows.Forms.ToolStripDropDownButton();
            this.findButOpenAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.findButOpenAsFileStandart = new System.Windows.Forms.ToolStripMenuItem();
            this.findButOpenAsFileTextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.findButOpenAsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainLogTextBox = new System.Windows.Forms.ListBox();
            this.ContextMenuData.SuspendLayout();
            this.MainMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelInfoFile.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // findListView
            // 
            this.findListView.CheckBoxes = true;
            this.findListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainListViewIndex,
            this.MainListViewNameFile,
            this.MainListViewFullPath,
            this.MainListViewFileSize,
            this.MainListViewNameEst});
            this.findListView.ContextMenuStrip = this.ContextMenuData;
            this.findListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findListView.FullRowSelect = true;
            this.findListView.GridLines = true;
            this.findListView.Location = new System.Drawing.Point(0, 49);
            this.findListView.MultiSelect = false;
            this.findListView.Name = "findListView";
            this.findListView.Size = new System.Drawing.Size(844, 207);
            this.findListView.TabIndex = 5;
            this.findListView.UseCompatibleStateImageBehavior = false;
            this.findListView.View = System.Windows.Forms.View.Details;
            this.findListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.sort_contacts);
            // 
            // MainListViewIndex
            // 
            this.MainListViewIndex.Text = "№";
            this.MainListViewIndex.Width = 24;
            // 
            // MainListViewNameFile
            // 
            this.MainListViewNameFile.Text = "Имя файла";
            this.MainListViewNameFile.Width = 169;
            // 
            // MainListViewFullPath
            // 
            this.MainListViewFullPath.Text = "Полный путь до файла";
            this.MainListViewFullPath.Width = 335;
            // 
            // MainListViewFileSize
            // 
            this.MainListViewFileSize.Text = "Размер";
            // 
            // MainListViewNameEst
            // 
            this.MainListViewNameEst.Text = "Расширение";
            this.MainListViewNameEst.Width = 88;
            // 
            // ContextMenuData
            // 
            this.ContextMenuData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuDataGetData,
            this.ContextMenuDataOpenFolder});
            this.ContextMenuData.Name = "contextMenuStrip1";
            this.ContextMenuData.Size = new System.Drawing.Size(173, 48);
            // 
            // ContextMenuDataGetData
            // 
            this.ContextMenuDataGetData.Name = "ContextMenuDataGetData";
            this.ContextMenuDataGetData.Size = new System.Drawing.Size(172, 22);
            this.ContextMenuDataGetData.Text = "Получить данные";
            this.ContextMenuDataGetData.Click += new System.EventHandler(this.получитьДанныеToolStripMenuItem_Click);
            // 
            // MainMenuStrip1
            // 
            this.MainMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainButFile,
            this.MainButSettings,
            this.MainButInfo,
            this.MainButLog});
            this.MainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip1.Name = "MainMenuStrip1";
            this.MainMenuStrip1.Size = new System.Drawing.Size(844, 24);
            this.MainMenuStrip1.TabIndex = 6;
            this.MainMenuStrip1.Text = "menuStrip1";
            // 
            // MainButFile
            // 
            this.MainButFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainButFileExit});
            this.MainButFile.Name = "MainButFile";
            this.MainButFile.Size = new System.Drawing.Size(48, 20);
            this.MainButFile.Text = "Файл";
            // 
            // MainButFileExit
            // 
            this.MainButFileExit.Name = "MainButFileExit";
            this.MainButFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MainButFileExit.Size = new System.Drawing.Size(150, 22);
            this.MainButFileExit.Text = "Выход";
            // 
            // MainButSettings
            // 
            this.MainButSettings.Name = "MainButSettings";
            this.MainButSettings.Size = new System.Drawing.Size(79, 20);
            this.MainButSettings.Text = "Настройки";
            // 
            // MainButInfo
            // 
            this.MainButInfo.Name = "MainButInfo";
            this.MainButInfo.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MainButInfo.Size = new System.Drawing.Size(93, 20);
            this.MainButInfo.Text = "Информация";
            this.MainButInfo.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // MainButLog
            // 
            this.MainButLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainButLogSave,
            this.MainButLogClear});
            this.MainButLog.Name = "MainButLog";
            this.MainButLog.Size = new System.Drawing.Size(39, 20);
            this.MainButLog.Text = "Лог";
            // 
            // MainButLogSave
            // 
            this.MainButLogSave.Name = "MainButLogSave";
            this.MainButLogSave.Size = new System.Drawing.Size(132, 22);
            this.MainButLogSave.Text = "Сохранить";
            this.MainButLogSave.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // MainButLogClear
            // 
            this.MainButLogClear.Name = "MainButLogClear";
            this.MainButLogClear.Size = new System.Drawing.Size(132, 22);
            this.MainButLogClear.Text = "Очистить";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77251F));
            this.tableLayoutPanel1.Controls.Add(this.PanelInfoFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainLogTextBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 118);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // PanelInfoFile
            // 
            this.PanelInfoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInfoFile.Controls.Add(this.progressBar1);
            this.PanelInfoFile.Controls.Add(this.LabelFileExt);
            this.PanelInfoFile.Controls.Add(this.LabelFileDataChange);
            this.PanelInfoFile.Controls.Add(this.LabelFileSize);
            this.PanelInfoFile.Controls.Add(this.LabelFileDataCreate);
            this.PanelInfoFile.Controls.Add(this.LabelFileName);
            this.PanelInfoFile.Controls.Add(this.tFileChange);
            this.PanelInfoFile.Controls.Add(this.tFileMask);
            this.PanelInfoFile.Controls.Add(this.tFileCreate);
            this.PanelInfoFile.Controls.Add(this.tFileSize);
            this.PanelInfoFile.Controls.Add(this.tFileName);
            this.PanelInfoFile.Location = new System.Drawing.Point(3, 3);
            this.PanelInfoFile.Name = "PanelInfoFile";
            this.PanelInfoFile.Size = new System.Drawing.Size(477, 109);
            this.PanelInfoFile.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(461, 18);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 12;
            // 
            // LabelFileExt
            // 
            this.LabelFileExt.AutoSize = true;
            this.LabelFileExt.Location = new System.Drawing.Point(16, 82);
            this.LabelFileExt.Name = "LabelFileExt";
            this.LabelFileExt.Size = new System.Drawing.Size(78, 13);
            this.LabelFileExt.TabIndex = 7;
            this.LabelFileExt.Text = "Маска файла:";
            // 
            // LabelFileDataChange
            // 
            this.LabelFileDataChange.AutoSize = true;
            this.LabelFileDataChange.Location = new System.Drawing.Point(201, 82);
            this.LabelFileDataChange.Name = "LabelFileDataChange";
            this.LabelFileDataChange.Size = new System.Drawing.Size(130, 13);
            this.LabelFileDataChange.TabIndex = 8;
            this.LabelFileDataChange.Text = "Дата изменения файла:";
            // 
            // LabelFileSize
            // 
            this.LabelFileSize.AutoSize = true;
            this.LabelFileSize.Location = new System.Drawing.Point(10, 56);
            this.LabelFileSize.Name = "LabelFileSize";
            this.LabelFileSize.Size = new System.Drawing.Size(84, 13);
            this.LabelFileSize.TabIndex = 9;
            this.LabelFileSize.Text = "Размер файла:";
            // 
            // LabelFileDataCreate
            // 
            this.LabelFileDataCreate.AutoSize = true;
            this.LabelFileDataCreate.Location = new System.Drawing.Point(209, 56);
            this.LabelFileDataCreate.Name = "LabelFileDataCreate";
            this.LabelFileDataCreate.Size = new System.Drawing.Size(122, 13);
            this.LabelFileDataCreate.TabIndex = 10;
            this.LabelFileDataCreate.Text = "Дата создания файла:";
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Location = new System.Drawing.Point(27, 30);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(67, 13);
            this.LabelFileName.TabIndex = 11;
            this.LabelFileName.Text = "Имя файла:";
            // 
            // tFileChange
            // 
            this.tFileChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileChange.Location = new System.Drawing.Point(337, 79);
            this.tFileChange.Name = "tFileChange";
            this.tFileChange.Size = new System.Drawing.Size(133, 20);
            this.tFileChange.TabIndex = 2;
            // 
            // tFileMask
            // 
            this.tFileMask.Location = new System.Drawing.Point(99, 79);
            this.tFileMask.Name = "tFileMask";
            this.tFileMask.Size = new System.Drawing.Size(96, 20);
            this.tFileMask.TabIndex = 3;
            // 
            // tFileCreate
            // 
            this.tFileCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileCreate.Location = new System.Drawing.Point(337, 53);
            this.tFileCreate.Name = "tFileCreate";
            this.tFileCreate.Size = new System.Drawing.Size(133, 20);
            this.tFileCreate.TabIndex = 4;
            // 
            // tFileSize
            // 
            this.tFileSize.Location = new System.Drawing.Point(99, 53);
            this.tFileSize.Name = "tFileSize";
            this.tFileSize.Size = new System.Drawing.Size(96, 20);
            this.tFileSize.TabIndex = 5;
            // 
            // tFileName
            // 
            this.tFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileName.Location = new System.Drawing.Point(100, 27);
            this.tFileName.Name = "tFileName";
            this.tFileName.Size = new System.Drawing.Size(371, 20);
            this.tFileName.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMask,
            this.findPath,
            this.findButFind,
            this.findButDelete,
            this.findButClear,
            this.findButCheckAll,
            this.findButOpenAs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // findMask
            // 
            this.findMask.Items.AddRange(new object[] {
            "*.*",
            "*.dat",
            "*.txt"});
            this.findMask.Name = "findMask";
            this.findMask.Size = new System.Drawing.Size(75, 25);
            // 
            // findPath
            // 
            this.findPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findPath.Name = "findPath";
            this.findPath.Size = new System.Drawing.Size(307, 25);
            this.findPath.Text = "D:\\fixNoobi\\Documents\\";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 253);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(844, 3);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document_pencil.png");
            this.imageList1.Images.SetKeyName(1, "gear_small.png");
            this.imageList1.Images.SetKeyName(2, "ui_check_box.png");
            this.imageList1.Images.SetKeyName(3, "ui_check_box_uncheck.png");
            // 
            // ContextMenuDataOpenFolder
            // 
            this.ContextMenuDataOpenFolder.Name = "ContextMenuDataOpenFolder";
            this.ContextMenuDataOpenFolder.Size = new System.Drawing.Size(172, 22);
            this.ContextMenuDataOpenFolder.Text = "Открыть папку..";
            // 
            // findButFind
            // 
            this.findButFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findButFind.Image = ((System.Drawing.Image)(resources.GetObject("findButFind.Image")));
            this.findButFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButFind.Name = "findButFind";
            this.findButFind.Size = new System.Drawing.Size(46, 22);
            this.findButFind.Text = "Поиск";
            this.findButFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // findButDelete
            // 
            this.findButDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findButDelete.Image = ((System.Drawing.Image)(resources.GetObject("findButDelete.Image")));
            this.findButDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButDelete.Name = "findButDelete";
            this.findButDelete.Size = new System.Drawing.Size(55, 22);
            this.findButDelete.Text = "Удалить";
            this.findButDelete.Click += new System.EventHandler(this.delit_selected_files_Click);
            // 
            // findButClear
            // 
            this.findButClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findButClear.Image = ((System.Drawing.Image)(resources.GetObject("findButClear.Image")));
            this.findButClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButClear.Name = "findButClear";
            this.findButClear.Size = new System.Drawing.Size(63, 22);
            this.findButClear.Text = "Очистить";
            this.findButClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // findButCheckAll
            // 
            this.findButCheckAll.CheckOnClick = true;
            this.findButCheckAll.Image = global::Deleter.Properties.Resources.ui_check_box_uncheck;
            this.findButCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButCheckAll.Name = "findButCheckAll";
            this.findButCheckAll.Size = new System.Drawing.Size(95, 22);
            this.findButCheckAll.Text = "Выбрать все";
            this.findButCheckAll.CheckedChanged += new System.EventHandler(this.all_vibor_CheckedChanged);
            // 
            // findButOpenAs
            // 
            this.findButOpenAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findButOpenAsFile,
            this.findButOpenAsFolder});
            this.findButOpenAs.Image = global::Deleter.Properties.Resources.gear_small;
            this.findButOpenAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButOpenAs.Name = "findButOpenAs";
            this.findButOpenAs.Size = new System.Drawing.Size(89, 22);
            this.findButOpenAs.Text = "Открыть..";
            this.findButOpenAs.Click += new System.EventHandler(this.button2_Click);
            // 
            // findButOpenAsFile
            // 
            this.findButOpenAsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findButOpenAsFileStandart,
            this.findButOpenAsFileTextEdit});
            this.findButOpenAsFile.Name = "findButOpenAsFile";
            this.findButOpenAsFile.Size = new System.Drawing.Size(108, 22);
            this.findButOpenAsFile.Text = "Файл";
            // 
            // findButOpenAsFileStandart
            // 
            this.findButOpenAsFileStandart.Name = "findButOpenAsFileStandart";
            this.findButOpenAsFileStandart.Size = new System.Drawing.Size(210, 22);
            this.findButOpenAsFileStandart.Text = "Стандартной програмой";
            // 
            // findButOpenAsFileTextEdit
            // 
            this.findButOpenAsFileTextEdit.Image = global::Deleter.Properties.Resources.document_pencil;
            this.findButOpenAsFileTextEdit.Name = "findButOpenAsFileTextEdit";
            this.findButOpenAsFileTextEdit.Size = new System.Drawing.Size(210, 22);
            this.findButOpenAsFileTextEdit.Text = "Текстовой редактор";
            // 
            // findButOpenAsFolder
            // 
            this.findButOpenAsFolder.Image = global::Deleter.Properties.Resources.folder_open_slide;
            this.findButOpenAsFolder.Name = "findButOpenAsFolder";
            this.findButOpenAsFolder.Size = new System.Drawing.Size(108, 22);
            this.findButOpenAsFolder.Text = "Папку";
            // 
            // MainLogTextBox
            // 
            this.MainLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLogTextBox.FormattingEnabled = true;
            this.MainLogTextBox.Location = new System.Drawing.Point(486, 3);
            this.MainLogTextBox.Name = "MainLogTextBox";
            this.MainLogTextBox.Size = new System.Drawing.Size(355, 112);
            this.MainLogTextBox.TabIndex = 13;
            // 
            // dForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 374);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.findListView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deleter";
            this.ContextMenuData.ResumeLayout(false);
            this.MainMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelInfoFile.ResumeLayout(false);
            this.PanelInfoFile.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ColumnHeader MainListViewIndex;
        public System.Windows.Forms.ColumnHeader MainListViewNameFile;
        public System.Windows.Forms.ColumnHeader MainListViewFullPath;
        public System.Windows.Forms.ColumnHeader MainListViewFileSize;
        private System.Windows.Forms.MenuStrip MainMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainButFile;
        private System.Windows.Forms.ToolStripMenuItem MainButSettings;
        private System.Windows.Forms.ToolStripMenuItem MainButInfo;
        private System.Windows.Forms.BindingSource logBindingSource;
        public System.Windows.Forms.ListView findListView;
        private System.Windows.Forms.ToolStripMenuItem MainButLog;
        private System.Windows.Forms.ToolStripMenuItem MainButLogSave;
        private System.Windows.Forms.ToolStripMenuItem MainButLogClear;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip ContextMenuData;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataGetData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelInfoFile;
        private System.Windows.Forms.Label LabelFileExt;
        private System.Windows.Forms.Label LabelFileDataChange;
        private System.Windows.Forms.Label LabelFileSize;
        private System.Windows.Forms.Label LabelFileDataCreate;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.TextBox tFileChange;
        private System.Windows.Forms.TextBox tFileMask;
        private System.Windows.Forms.TextBox tFileCreate;
        private System.Windows.Forms.TextBox tFileSize;
        private System.Windows.Forms.TextBox tFileName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox findMask;
        private System.Windows.Forms.ToolStripTextBox findPath;
        private System.Windows.Forms.ToolStripButton findButFind;
        private System.Windows.Forms.ToolStripButton findButDelete;
        private System.Windows.Forms.ToolStripButton findButClear;
        private System.Windows.Forms.ToolStripButton findButCheckAll;
        private System.Windows.Forms.ColumnHeader MainListViewNameEst;
        private System.Windows.Forms.ToolStripMenuItem MainButFileExit;
        private System.Windows.Forms.ToolStripDropDownButton findButOpenAs;
        private System.Windows.Forms.ToolStripMenuItem findButOpenAsFile;
        private System.Windows.Forms.ToolStripMenuItem findButOpenAsFolder;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem findButOpenAsFileStandart;
        private System.Windows.Forms.ToolStripMenuItem findButOpenAsFileTextEdit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataOpenFolder;
        private System.Windows.Forms.ListBox MainLogTextBox;
    }
}

