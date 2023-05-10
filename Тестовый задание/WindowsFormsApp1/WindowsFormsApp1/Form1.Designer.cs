namespace WindowsFormsApp1
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.NumFiles = new System.Windows.Forms.NumericUpDown();
            this.MaxNumWords = new System.Windows.Forms.NumericUpDown();
            this.MinNumWords = new System.Windows.Forms.NumericUpDown();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BigRedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumWords)).BeginInit();
            this.SuspendLayout();
            // 
            // NumFiles
            // 
            this.NumFiles.Location = new System.Drawing.Point(65, 279);
            this.NumFiles.Name = "NumFiles";
            this.NumFiles.Size = new System.Drawing.Size(120, 22);
            this.NumFiles.TabIndex = 0;
            // 
            // MaxNumWords
            // 
            this.MaxNumWords.Location = new System.Drawing.Point(65, 174);
            this.MaxNumWords.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.MaxNumWords.Name = "MaxNumWords";
            this.MaxNumWords.Size = new System.Drawing.Size(120, 22);
            this.MaxNumWords.TabIndex = 1;
            // 
            // MinNumWords
            // 
            this.MinNumWords.Location = new System.Drawing.Point(65, 75);
            this.MinNumWords.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.MinNumWords.Name = "MinNumWords";
            this.MinNumWords.Size = new System.Drawing.Size(120, 22);
            this.MinNumWords.TabIndex = 2;
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(65, 379);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(662, 22);
            this.FilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Минимальное количество слов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Максимальное количество слов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество файлов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(62, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Путь к файлу:";
            // 
            // BigRedButton
            // 
            this.BigRedButton.BackColor = System.Drawing.Color.Red;
            this.BigRedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigRedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BigRedButton.Location = new System.Drawing.Point(325, 56);
            this.BigRedButton.Name = "BigRedButton";
            this.BigRedButton.Size = new System.Drawing.Size(402, 245);
            this.BigRedButton.TabIndex = 8;
            this.BigRedButton.Text = "БОЛЬШАЯ\r\nКРАСНАЯ\r\nКНОПКА";
            this.BigRedButton.UseVisualStyleBackColor = false;
            this.BigRedButton.Click += new System.EventHandler(this.BigRedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BigRedButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.MinNumWords);
            this.Controls.Add(this.MaxNumWords);
            this.Controls.Add(this.NumFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumFiles;
        private System.Windows.Forms.NumericUpDown MaxNumWords;
        private System.Windows.Forms.NumericUpDown MinNumWords;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BigRedButton;
    }
}

