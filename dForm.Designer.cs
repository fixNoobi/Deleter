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
            this.FindListView = new System.Windows.Forms.ListView();
            this.FindListViewIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FindListViewNameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FindListViewFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FindListViewSizeFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FindListViewEst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuDataGetInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDataFileStandart = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDataFileTextEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDataOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuStrip1File = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1Info = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1Log = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1LogSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1LogClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerSelectedCount = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainLogTextBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tFileChange = new System.Windows.Forms.TextBox();
            this.tFileMask = new System.Windows.Forms.TextBox();
            this.tFileCreate = new System.Windows.Forms.TextBox();
            this.tFileSize = new System.Windows.Forms.TextBox();
            this.tFileCountSelected = new System.Windows.Forms.TextBox();
            this.tFileCount = new System.Windows.Forms.TextBox();
            this.tFileName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.findMask = new System.Windows.Forms.ToolStripComboBox();
            this.findPath = new System.Windows.Forms.ToolStripComboBox();
            this.findButFind = new System.Windows.Forms.ToolStripButton();
            this.findButDelete = new System.Windows.Forms.ToolStripButton();
            this.findButClear = new System.Windows.Forms.ToolStripButton();
            this.findButCheckAll = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.MainMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindListView
            // 
            this.FindListView.CheckBoxes = true;
            this.FindListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FindListViewIndex,
            this.FindListViewNameFile,
            this.FindListViewFullPath,
            this.FindListViewSizeFile,
            this.FindListViewEst});
            this.FindListView.ContextMenuStrip = this.contextMenuStrip1;
            this.FindListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindListView.FullRowSelect = true;
            this.FindListView.GridLines = true;
            this.FindListView.Location = new System.Drawing.Point(0, 49);
            this.FindListView.MultiSelect = false;
            this.FindListView.Name = "FindListView";
            this.FindListView.Size = new System.Drawing.Size(844, 209);
            this.FindListView.TabIndex = 5;
            this.FindListView.UseCompatibleStateImageBehavior = false;
            this.FindListView.View = System.Windows.Forms.View.Details;
            this.FindListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.sort_contacts);
            this.FindListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FindListView_ItemCheck);
            // 
            // FindListViewIndex
            // 
            this.FindListViewIndex.Text = "№";
            this.FindListViewIndex.Width = 24;
            // 
            // FindListViewNameFile
            // 
            this.FindListViewNameFile.Text = "Имя файла";
            this.FindListViewNameFile.Width = 169;
            // 
            // FindListViewFullPath
            // 
            this.FindListViewFullPath.Text = "Полный путь до файла";
            this.FindListViewFullPath.Width = 335;
            // 
            // FindListViewSizeFile
            // 
            this.FindListViewSizeFile.Text = "Размер";
            // 
            // FindListViewEst
            // 
            this.FindListViewEst.Text = "Расширение";
            this.FindListViewEst.Width = 88;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuDataGetInfo,
            this.ContextMenuDataFile,
            this.ContextMenuDataOpenFolder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ContextMenuDataGetInfo
            // 
            this.ContextMenuDataGetInfo.Name = "ContextMenuDataGetInfo";
            this.ContextMenuDataGetInfo.Size = new System.Drawing.Size(172, 22);
            this.ContextMenuDataGetInfo.Text = "Получить данные";
            this.ContextMenuDataGetInfo.Click += new System.EventHandler(this.ContextMenuDataGetInfo_Click);
            // 
            // ContextMenuDataFile
            // 
            this.ContextMenuDataFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuDataFileStandart,
            this.ContextMenuDataFileTextEditor});
            this.ContextMenuDataFile.Name = "ContextMenuDataFile";
            this.ContextMenuDataFile.Size = new System.Drawing.Size(172, 22);
            this.ContextMenuDataFile.Text = "Файл";
            // 
            // ContextMenuDataFileStandart
            // 
            this.ContextMenuDataFileStandart.Image = global::Deleter.Properties.Resources.arrow_315_medium;
            this.ContextMenuDataFileStandart.Name = "ContextMenuDataFileStandart";
            this.ContextMenuDataFileStandart.Size = new System.Drawing.Size(210, 22);
            this.ContextMenuDataFileStandart.Text = "Стандартной програмой";
            // 
            // ContextMenuDataFileTextEditor
            // 
            this.ContextMenuDataFileTextEditor.Image = global::Deleter.Properties.Resources.document_pencil;
            this.ContextMenuDataFileTextEditor.Name = "ContextMenuDataFileTextEditor";
            this.ContextMenuDataFileTextEditor.Size = new System.Drawing.Size(210, 22);
            this.ContextMenuDataFileTextEditor.Text = "Текстовой редактор";
            this.ContextMenuDataFileTextEditor.Click += new System.EventHandler(this.findButOpenAsFileTextEdit_Click);
            // 
            // ContextMenuDataOpenFolder
            // 
            this.ContextMenuDataOpenFolder.Image = global::Deleter.Properties.Resources.folder_open_slide;
            this.ContextMenuDataOpenFolder.Name = "ContextMenuDataOpenFolder";
            this.ContextMenuDataOpenFolder.Size = new System.Drawing.Size(172, 22);
            this.ContextMenuDataOpenFolder.Text = "Папку";
            // 
            // MainMenuStrip1
            // 
            this.MainMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuStrip1File,
            this.MainMenuStrip1Settings,
            this.MainMenuStrip1Info,
            this.MainMenuStrip1Log});
            this.MainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip1.Name = "MainMenuStrip1";
            this.MainMenuStrip1.Size = new System.Drawing.Size(844, 24);
            this.MainMenuStrip1.TabIndex = 6;
            this.MainMenuStrip1.Text = "menuStrip1";
            // 
            // MainMenuStrip1File
            // 
            this.MainMenuStrip1File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuStrip1FileExit});
            this.MainMenuStrip1File.Name = "MainMenuStrip1File";
            this.MainMenuStrip1File.Size = new System.Drawing.Size(48, 20);
            this.MainMenuStrip1File.Text = "Файл";
            // 
            // MainMenuStrip1FileExit
            // 
            this.MainMenuStrip1FileExit.Image = global::Deleter.Properties.Resources.door_open_out;
            this.MainMenuStrip1FileExit.Name = "MainMenuStrip1FileExit";
            this.MainMenuStrip1FileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MainMenuStrip1FileExit.Size = new System.Drawing.Size(152, 22);
            this.MainMenuStrip1FileExit.Text = "Выход";
            this.MainMenuStrip1FileExit.Click += new System.EventHandler(this.MainMenuStrip1FileExit_Click);
            // 
            // MainMenuStrip1Settings
            // 
            this.MainMenuStrip1Settings.Name = "MainMenuStrip1Settings";
            this.MainMenuStrip1Settings.Size = new System.Drawing.Size(79, 20);
            this.MainMenuStrip1Settings.Text = "Настройки";
            // 
            // MainMenuStrip1Info
            // 
            this.MainMenuStrip1Info.Name = "MainMenuStrip1Info";
            this.MainMenuStrip1Info.Size = new System.Drawing.Size(93, 20);
            this.MainMenuStrip1Info.Text = "Информация";
            // 
            // MainMenuStrip1Log
            // 
            this.MainMenuStrip1Log.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuStrip1LogSave,
            this.MainMenuStrip1LogClear});
            this.MainMenuStrip1Log.Name = "MainMenuStrip1Log";
            this.MainMenuStrip1Log.Size = new System.Drawing.Size(39, 20);
            this.MainMenuStrip1Log.Text = "Лог";
            // 
            // MainMenuStrip1LogSave
            // 
            this.MainMenuStrip1LogSave.Image = global::Deleter.Properties.Resources.clipboard_arrow;
            this.MainMenuStrip1LogSave.Name = "MainMenuStrip1LogSave";
            this.MainMenuStrip1LogSave.Size = new System.Drawing.Size(132, 22);
            this.MainMenuStrip1LogSave.Text = "Сохранить";
            this.MainMenuStrip1LogSave.Click += new System.EventHandler(this.MainMenuStrip1LogSave_Click);
            // 
            // MainMenuStrip1LogClear
            // 
            this.MainMenuStrip1LogClear.Image = global::Deleter.Properties.Resources.clipboard;
            this.MainMenuStrip1LogClear.Name = "MainMenuStrip1LogClear";
            this.MainMenuStrip1LogClear.Size = new System.Drawing.Size(132, 22);
            this.MainMenuStrip1LogClear.Text = "Очистить";
            this.MainMenuStrip1LogClear.Click += new System.EventHandler(this.MainMenuStrip1LogClear_Click);
            // 
            // TimerSelectedCount
            // 
            this.TimerSelectedCount.Enabled = true;
            this.TimerSelectedCount.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77251F));
            this.tableLayoutPanel1.Controls.Add(this.MainLogTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 261);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 113);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // MainLogTextBox
            // 
            this.MainLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLogTextBox.FormattingEnabled = true;
            this.MainLogTextBox.Location = new System.Drawing.Point(486, 3);
            this.MainLogTextBox.Name = "MainLogTextBox";
            this.MainLogTextBox.ScrollAlwaysVisible = true;
            this.MainLogTextBox.Size = new System.Drawing.Size(355, 107);
            this.MainLogTextBox.TabIndex = 14;
            this.MainLogTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainLogTextBox_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tFileChange);
            this.panel3.Controls.Add(this.tFileMask);
            this.panel3.Controls.Add(this.tFileCreate);
            this.panel3.Controls.Add(this.tFileSize);
            this.panel3.Controls.Add(this.tFileCountSelected);
            this.panel3.Controls.Add(this.tFileCount);
            this.panel3.Controls.Add(this.tFileName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 107);
            this.panel3.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(354, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(111, 17);
            this.progressBar1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Выделено файлов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Всего файлов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Маска файла:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата изменения файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Размер файла:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата создания файла:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя файла:";
            // 
            // tFileChange
            // 
            this.tFileChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileChange.Location = new System.Drawing.Point(334, 81);
            this.tFileChange.Name = "tFileChange";
            this.tFileChange.Size = new System.Drawing.Size(131, 20);
            this.tFileChange.TabIndex = 2;
            // 
            // tFileMask
            // 
            this.tFileMask.Location = new System.Drawing.Point(96, 81);
            this.tFileMask.Name = "tFileMask";
            this.tFileMask.Size = new System.Drawing.Size(96, 20);
            this.tFileMask.TabIndex = 3;
            // 
            // tFileCreate
            // 
            this.tFileCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileCreate.Location = new System.Drawing.Point(334, 55);
            this.tFileCreate.Name = "tFileCreate";
            this.tFileCreate.Size = new System.Drawing.Size(131, 20);
            this.tFileCreate.TabIndex = 4;
            // 
            // tFileSize
            // 
            this.tFileSize.Location = new System.Drawing.Point(96, 55);
            this.tFileSize.Name = "tFileSize";
            this.tFileSize.Size = new System.Drawing.Size(96, 20);
            this.tFileSize.TabIndex = 5;
            // 
            // tFileCountSelected
            // 
            this.tFileCountSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileCountSelected.Enabled = false;
            this.tFileCountSelected.Location = new System.Drawing.Point(284, 3);
            this.tFileCountSelected.Name = "tFileCountSelected";
            this.tFileCountSelected.Size = new System.Drawing.Size(64, 20);
            this.tFileCountSelected.TabIndex = 6;
            // 
            // tFileCount
            // 
            this.tFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileCount.Enabled = false;
            this.tFileCount.Location = new System.Drawing.Point(96, 3);
            this.tFileCount.Name = "tFileCount";
            this.tFileCount.Size = new System.Drawing.Size(64, 20);
            this.tFileCount.TabIndex = 6;
            // 
            // tFileName
            // 
            this.tFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFileName.Location = new System.Drawing.Point(97, 29);
            this.tFileName.Name = "tFileName";
            this.tFileName.Size = new System.Drawing.Size(369, 20);
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
            this.findButCheckAll});
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
            this.findMask.Text = "*.*";
            // 
            // findPath
            // 
            this.findPath.Name = "findPath";
            this.findPath.Size = new System.Drawing.Size(307, 25);
            this.findPath.Text = "D:\\fixNoobi\\Documents\\";
            this.findPath.ToolTipText = "Если в конце стоит знак \'\\\' - то поиск будет производиться и в подпапках\r\nЕсли в " +
    "конец нету знака \'\\\' - то поиск будет производиться только в этой папке";
            this.findPath.TextChanged += new System.EventHandler(this.PathForFile_TextChanged);
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
            this.findButDelete.Click += new System.EventHandler(this.findButDelete_Click);
            // 
            // findButClear
            // 
            this.findButClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findButClear.Image = ((System.Drawing.Image)(resources.GetObject("findButClear.Image")));
            this.findButClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButClear.Name = "findButClear";
            this.findButClear.Size = new System.Drawing.Size(63, 22);
            this.findButClear.Text = "Очистить";
            this.findButClear.Click += new System.EventHandler(this.findButClear_Click);
            // 
            // findButCheckAll
            // 
            this.findButCheckAll.CheckOnClick = true;
            this.findButCheckAll.Image = global::Deleter.Properties.Resources.ui_check_box_uncheck;
            this.findButCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findButCheckAll.Name = "findButCheckAll";
            this.findButCheckAll.Size = new System.Drawing.Size(95, 22);
            this.findButCheckAll.Text = "Выбрать все";
            this.findButCheckAll.CheckedChanged += new System.EventHandler(this.findButCheckAll_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 258);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(844, 3);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // dForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 374);
            this.Controls.Add(this.FindListView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuStrip1;
            this.Name = "dForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deleter";
            this.contextMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ColumnHeader FindListViewIndex;
        public System.Windows.Forms.ColumnHeader FindListViewNameFile;
        public System.Windows.Forms.ColumnHeader FindListViewFullPath;
        public System.Windows.Forms.ColumnHeader FindListViewSizeFile;
        private System.Windows.Forms.MenuStrip MainMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1File;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1Settings;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1Info;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1Log;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1LogSave;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1LogClear;
        public System.Windows.Forms.Timer TimerSelectedCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataGetInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tFileChange;
        private System.Windows.Forms.TextBox tFileMask;
        private System.Windows.Forms.TextBox tFileCreate;
        private System.Windows.Forms.TextBox tFileSize;
        private System.Windows.Forms.TextBox tFileName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox findMask;
        private System.Windows.Forms.ToolStripButton findButFind;
        private System.Windows.Forms.ToolStripButton findButDelete;
        private System.Windows.Forms.ToolStripButton findButClear;
        private System.Windows.Forms.ToolStripButton findButCheckAll;
        private System.Windows.Forms.ColumnHeader FindListViewEst;
        private System.Windows.Forms.ToolStripMenuItem MainMenuStrip1FileExit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox MainLogTextBox;
        public System.Windows.Forms.ListView FindListView;
        private System.Windows.Forms.ToolStripComboBox findPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tFileCountSelected;
        private System.Windows.Forms.TextBox tFileCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataFile;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataFileStandart;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataFileTextEditor;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDataOpenFolder;
    }
}

