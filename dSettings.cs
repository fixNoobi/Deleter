namespace Deleter
{
    partial class dSettings
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.app_settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Отоброжать окно лога?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // app_settings
            // 
            this.app_settings.Location = new System.Drawing.Point(212, 12);
            this.app_settings.Name = "app_settings";
            this.app_settings.Size = new System.Drawing.Size(75, 23);
            this.app_settings.TabIndex = 1;
            this.app_settings.Text = "Применить";
            this.app_settings.UseVisualStyleBackColor = true;
            this.app_settings.Click += new System.EventHandler(this.app_settings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(212, 41);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 1;
            this.exits.Text = "Выход";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(291, 87);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.app_settings);
            this.Controls.Add(this.checkBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button app_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exits;

    }
}
