namespace Deleter
{
    partial class dTextEditor
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
            this.components = new System.ComponentModel.Container();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ToolStripMainButFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMainButFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMainButFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMainButFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMainButFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.StatusStripMainLenghtText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripMainSizeFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripMainNameFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.ToolStripMain.SuspendLayout();
            this.StatusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMainButFile});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(464, 25);
            this.ToolStripMain.TabIndex = 0;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // ToolStripMainButFile
            // 
            this.ToolStripMainButFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMainButFileOpen,
            this.toolStripMenuItem2,
            this.ToolStripMainButFileSave,
            this.ToolStripMainButFileSaveAs,
            this.toolStripMenuItem1,
            this.ToolStripMainButFileExit});
            this.ToolStripMainButFile.Image = global::Deleter.Properties.Resources.arrow_315_medium;
            this.ToolStripMainButFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMainButFile.Name = "ToolStripMainButFile";
            this.ToolStripMainButFile.Size = new System.Drawing.Size(65, 22);
            this.ToolStripMainButFile.Text = "&Файл";
            // 
            // ToolStripMainButFileOpen
            // 
            this.ToolStripMainButFileOpen.Image = global::Deleter.Properties.Resources.clipboard;
            this.ToolStripMainButFileOpen.Name = "ToolStripMainButFileOpen";
            this.ToolStripMainButFileOpen.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMainButFileOpen.Text = "Открыть..";
            this.ToolStripMainButFileOpen.Click += new System.EventHandler(this.ToolStripMainButFileOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // ToolStripMainButFileSave
            // 
            this.ToolStripMainButFileSave.Image = global::Deleter.Properties.Resources.disk_arrow;
            this.ToolStripMainButFileSave.Name = "ToolStripMainButFileSave";
            this.ToolStripMainButFileSave.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMainButFileSave.Text = "Сохранить";
            // 
            // ToolStripMainButFileSaveAs
            // 
            this.ToolStripMainButFileSaveAs.Name = "ToolStripMainButFileSaveAs";
            this.ToolStripMainButFileSaveAs.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMainButFileSaveAs.Text = "Сохранить как..";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // ToolStripMainButFileExit
            // 
            this.ToolStripMainButFileExit.Image = global::Deleter.Properties.Resources.door_open_out;
            this.ToolStripMainButFileExit.Name = "ToolStripMainButFileExit";
            this.ToolStripMainButFileExit.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMainButFileExit.Text = "Выход";
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripMainLenghtText,
            this.StatusStripMainSizeFile,
            this.StatusStripMainNameFile});
            this.StatusStripMain.Location = new System.Drawing.Point(0, 275);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusStripMain.Size = new System.Drawing.Size(464, 24);
            this.StatusStripMain.TabIndex = 2;
            this.StatusStripMain.Text = "statusStrip1";
            // 
            // StatusStripMainLenghtText
            // 
            this.StatusStripMainLenghtText.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusStripMainLenghtText.Name = "StatusStripMainLenghtText";
            this.StatusStripMainLenghtText.Size = new System.Drawing.Size(74, 19);
            this.StatusStripMainLenghtText.Text = "Символов: ";
            // 
            // StatusStripMainSizeFile
            // 
            this.StatusStripMainSizeFile.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusStripMainSizeFile.Name = "StatusStripMainSizeFile";
            this.StatusStripMainSizeFile.Size = new System.Drawing.Size(95, 19);
            this.StatusStripMainSizeFile.Text = "Размер файла: ";
            // 
            // StatusStripMainNameFile
            // 
            this.StatusStripMainNameFile.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusStripMainNameFile.IsLink = true;
            this.StatusStripMainNameFile.Name = "StatusStripMainNameFile";
            this.StatusStripMainNameFile.Size = new System.Drawing.Size(79, 19);
            this.StatusStripMainNameFile.Text = "Имя файла: ";
            this.StatusStripMainNameFile.Click += new System.EventHandler(this.StatusStripMainNameFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 250);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            // 
            // dTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 299);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StatusStripMain);
            this.Controls.Add(this.ToolStripMain);
            this.Name = "dTextEditor";
            this.Text = "Текстовой редактор";
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.StatusStripMain.ResumeLayout(false);
            this.StatusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripMainButFile;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripMainLenghtText;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMainButFileExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMainButFileOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMainButFileSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMainButFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripMainSizeFile;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripMainNameFile;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}
