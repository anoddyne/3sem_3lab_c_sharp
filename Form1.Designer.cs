namespace _3sem_3lab_c_sharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.textFileInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.invertedFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputString = new System.Windows.Forms.TextBox();
            this.invertString = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.invertedStringOutput = new System.Windows.Forms.TextBox();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текстовый файл";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(391, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Лабораторная работа №3, вариант 1.";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comment.Location = new System.Drawing.Point(12, 34);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(631, 20);
            this.comment.TabIndex = 2;
            this.comment.Text = "Дана строка. Напечатать входящие в нее слова, но в обратном порядке.";
            // 
            // textFileInput
            // 
            this.textFileInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileInput.BackColor = System.Drawing.Color.White;
            this.textFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFileInput.Location = new System.Drawing.Point(17, 100);
            this.textFileInput.Name = "textFileInput";
            this.textFileInput.ReadOnly = true;
            this.textFileInput.Size = new System.Drawing.Size(626, 28);
            this.textFileInput.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Инвертированная строка из входного файла";
            // 
            // invertedFile
            // 
            this.invertedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedFile.BackColor = System.Drawing.Color.White;
            this.invertedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invertedFile.Location = new System.Drawing.Point(17, 174);
            this.invertedFile.Name = "invertedFile";
            this.invertedFile.ReadOnly = true;
            this.invertedFile.Size = new System.Drawing.Size(771, 28);
            this.invertedFile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите строку:";
            // 
            // inputString
            // 
            this.inputString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputString.Location = new System.Drawing.Point(17, 254);
            this.inputString.Name = "inputString";
            this.inputString.Size = new System.Drawing.Size(626, 28);
            this.inputString.TabIndex = 7;
            // 
            // invertString
            // 
            this.invertString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invertString.Location = new System.Drawing.Point(649, 254);
            this.invertString.Name = "invertString";
            this.invertString.Size = new System.Drawing.Size(139, 28);
            this.invertString.TabIndex = 8;
            this.invertString.Text = "Инвертировать";
            this.invertString.UseVisualStyleBackColor = true;
            this.invertString.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Полученная инвертированная строка:";
            // 
            // invertedStringOutput
            // 
            this.invertedStringOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invertedStringOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invertedStringOutput.Location = new System.Drawing.Point(17, 331);
            this.invertedStringOutput.Name = "invertedStringOutput";
            this.invertedStringOutput.Size = new System.Drawing.Size(771, 28);
            this.invertedStringOutput.TabIndex = 10;
            // 
            // outputFileButton
            // 
            this.outputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileButton.Location = new System.Drawing.Point(649, 100);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(139, 28);
            this.outputFileButton.TabIndex = 11;
            this.outputFileButton.Text = "Вывести";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 383);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.invertedStringOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invertString);
            this.Controls.Add(this.inputString);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.invertedFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFileInput);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(700, 430);
            this.Name = "Form1";
            this.Text = "3 задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.TextBox textFileInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox invertedFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputString;
        private System.Windows.Forms.Button invertString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox invertedStringOutput;
        private System.Windows.Forms.Button outputFileButton;
    }
}

