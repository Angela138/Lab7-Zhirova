namespace Lab7_Zhirova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton3Des = new System.Windows.Forms.RadioButton();
            this.radioButtonAes = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonGIV = new System.Windows.Forms.Button();
            this.textIV = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGKey = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbKeySize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textOutFileSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textOutFileEntropy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bOut = new System.Windows.Forms.Button();
            this.textOutPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textInFileSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textInFileEntropy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bIn = new System.Windows.Forms.Button();
            this.textInPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textTime);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.buttonStop);
            this.groupBox8.Controls.Add(this.buttonDecrypt);
            this.groupBox8.Controls.Add(this.buttonEncrypt);
            this.groupBox8.Location = new System.Drawing.Point(7, 394);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(649, 57);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Дії";
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Location = new System.Drawing.Point(499, 30);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(49, 13);
            this.textTime.TabIndex = 4;
            this.textTime.Text = "00:00:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Час розрахунку:";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(218, 20);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Зупинити";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(106, 19);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(95, 24);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Розшифрувати";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(13, 19);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(85, 24);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Зашифрувати";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton3Des);
            this.groupBox7.Controls.Add(this.radioButtonAes);
            this.groupBox7.Location = new System.Drawing.Point(8, 350);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(649, 38);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Алгоритм шифрування";
            // 
            // radioButton3Des
            // 
            this.radioButton3Des.AutoSize = true;
            this.radioButton3Des.Location = new System.Drawing.Point(136, 15);
            this.radioButton3Des.Name = "radioButton3Des";
            this.radioButton3Des.Size = new System.Drawing.Size(53, 17);
            this.radioButton3Des.TabIndex = 1;
            this.radioButton3Des.TabStop = true;
            this.radioButton3Des.Text = "3DES";
            this.radioButton3Des.UseVisualStyleBackColor = true;
            this.radioButton3Des.CheckedChanged += new System.EventHandler(this.radioButton3Des_CheckedChanged);
            // 
            // radioButtonAes
            // 
            this.radioButtonAes.AutoSize = true;
            this.radioButtonAes.Location = new System.Drawing.Point(22, 15);
            this.radioButtonAes.Name = "radioButtonAes";
            this.radioButtonAes.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAes.TabIndex = 0;
            this.radioButtonAes.TabStop = true;
            this.radioButtonAes.Text = "AES";
            this.radioButtonAes.UseVisualStyleBackColor = true;
            this.radioButtonAes.CheckedChanged += new System.EventHandler(this.radioButtonAes_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.buttonGIV);
            this.groupBox6.Controls.Add(this.textIV);
            this.groupBox6.Location = new System.Drawing.Point(7, 291);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(649, 53);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Вектор ініціалізації";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(433, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Bl = 0";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonGIV
            // 
            this.buttonGIV.Image = ((System.Drawing.Image)(resources.GetObject("buttonGIV.Image")));
            this.buttonGIV.Location = new System.Drawing.Point(351, 0);
            this.buttonGIV.Name = "buttonGIV";
            this.buttonGIV.Size = new System.Drawing.Size(76, 53);
            this.buttonGIV.TabIndex = 1;
            this.buttonGIV.Text = "  ";
            this.buttonGIV.UseVisualStyleBackColor = true;
            this.buttonGIV.Click += new System.EventHandler(this.buttonGIV_Click);
            // 
            // textIV
            // 
            this.textIV.Location = new System.Drawing.Point(24, 20);
            this.textIV.Name = "textIV";
            this.textIV.Size = new System.Drawing.Size(301, 20);
            this.textIV.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonLoad);
            this.groupBox5.Controls.Add(this.buttonSave);
            this.groupBox5.Controls.Add(this.buttonGKey);
            this.groupBox5.Controls.Add(this.textKey);
            this.groupBox5.Location = new System.Drawing.Point(7, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(651, 49);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ключ";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
            this.buttonLoad.Location = new System.Drawing.Point(581, 0);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(64, 49);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "  ";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(502, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(64, 49);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = " ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGKey
            // 
            this.buttonGKey.Image = ((System.Drawing.Image)(resources.GetObject("buttonGKey.Image")));
            this.buttonGKey.Location = new System.Drawing.Point(351, 0);
            this.buttonGKey.Name = "buttonGKey";
            this.buttonGKey.Size = new System.Drawing.Size(84, 49);
            this.buttonGKey.TabIndex = 1;
            this.buttonGKey.Text = "  ";
            this.buttonGKey.UseVisualStyleBackColor = true;
            this.buttonGKey.Click += new System.EventHandler(this.buttonGKey_Click);
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(23, 20);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(302, 20);
            this.textKey.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Controls.Add(this.cbKeySize);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(8, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(650, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметри";
            // 
            // cbKeySize
            // 
            this.cbKeySize.FormattingEnabled = true;
            this.cbKeySize.Items.AddRange(new object[] {
            "128",
            "256"});
            this.cbKeySize.Location = new System.Drawing.Point(126, 29);
            this.cbKeySize.Name = "cbKeySize";
            this.cbKeySize.Size = new System.Drawing.Size(74, 21);
            this.cbKeySize.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Довжина ключа (біт):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textOutFileSize);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textOutFileEntropy);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.bOut);
            this.groupBox3.Controls.Add(this.textOutPath);
            this.groupBox3.Location = new System.Drawing.Point(10, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вихідний";
            // 
            // textOutFileSize
            // 
            this.textOutFileSize.AutoSize = true;
            this.textOutFileSize.Location = new System.Drawing.Point(388, 43);
            this.textOutFileSize.Name = "textOutFileSize";
            this.textOutFileSize.Size = new System.Drawing.Size(25, 13);
            this.textOutFileSize.TabIndex = 5;
            this.textOutFileSize.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Розмір";
            // 
            // textOutFileEntropy
            // 
            this.textOutFileEntropy.AutoSize = true;
            this.textOutFileEntropy.Location = new System.Drawing.Point(87, 44);
            this.textOutFileEntropy.Name = "textOutFileEntropy";
            this.textOutFileEntropy.Size = new System.Drawing.Size(25, 13);
            this.textOutFileEntropy.TabIndex = 3;
            this.textOutFileEntropy.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ентропія";
            // 
            // bOut
            // 
            this.bOut.Location = new System.Drawing.Point(577, 15);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(43, 23);
            this.bOut.TabIndex = 1;
            this.bOut.Text = "...";
            this.bOut.UseVisualStyleBackColor = true;
            this.bOut.Click += new System.EventHandler(this.bOut_Click);
            // 
            // textOutPath
            // 
            this.textOutPath.Location = new System.Drawing.Point(20, 17);
            this.textOutPath.Name = "textOutPath";
            this.textOutPath.Size = new System.Drawing.Size(542, 20);
            this.textOutPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textInFileSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textInFileEntropy);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bIn);
            this.groupBox2.Controls.Add(this.textInPath);
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вхідний";
            // 
            // textInFileSize
            // 
            this.textInFileSize.AutoSize = true;
            this.textInFileSize.Location = new System.Drawing.Point(388, 40);
            this.textInFileSize.Name = "textInFileSize";
            this.textInFileSize.Size = new System.Drawing.Size(25, 13);
            this.textInFileSize.TabIndex = 5;
            this.textInFileSize.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Розмір";
            // 
            // textInFileEntropy
            // 
            this.textInFileEntropy.AutoSize = true;
            this.textInFileEntropy.Location = new System.Drawing.Point(87, 40);
            this.textInFileEntropy.Name = "textInFileEntropy";
            this.textInFileEntropy.Size = new System.Drawing.Size(25, 13);
            this.textInFileEntropy.TabIndex = 3;
            this.textInFileEntropy.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ентропія";
            // 
            // bIn
            // 
            this.bIn.Location = new System.Drawing.Point(578, 11);
            this.bIn.Name = "bIn";
            this.bIn.Size = new System.Drawing.Size(43, 23);
            this.bIn.TabIndex = 1;
            this.bIn.Text = "...";
            this.bIn.UseVisualStyleBackColor = true;
            this.bIn.Click += new System.EventHandler(this.bIn_Click);
            // 
            // textInPath
            // 
            this.textInPath.Location = new System.Drawing.Point(21, 14);
            this.textInPath.Name = "textInPath";
            this.textInPath.Size = new System.Drawing.Size(542, 20);
            this.textInPath.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 481);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Блокові шифри";
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RadioButton radioButton3Des;
        private System.Windows.Forms.RadioButton radioButtonAes;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonGIV;
        private System.Windows.Forms.TextBox textIV;
        private System.Windows.Forms.Button buttonGKey;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.ComboBox cbKeySize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label textOutFileSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textOutFileEntropy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bOut;
        private System.Windows.Forms.TextBox textOutPath;
        private System.Windows.Forms.Label textInFileSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textInFileEntropy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIn;
        private System.Windows.Forms.TextBox textInPath;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
    }
}

