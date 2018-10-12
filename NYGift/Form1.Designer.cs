namespace NYGift
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
            this.buttondel = new System.Windows.Forms.Button();
            this.buttonsort = new System.Windows.Forms.Button();
            this.buttonfind = new System.Windows.Forms.Button();
            this.buttoninfo = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.radioCandy = new System.Windows.Forms.RadioButton();
            this.radioChocolate = new System.Windows.Forms.RadioButton();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelMinSugar = new System.Windows.Forms.Label();
            this.labelMaxSugar = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelTypeOfChocolate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSugar = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(433, 241);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(99, 29);
            this.buttondel.TabIndex = 0;
            this.buttondel.Text = "Delete";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsort
            // 
            this.buttonsort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonsort.Location = new System.Drawing.Point(27, 76);
            this.buttonsort.Name = "buttonsort";
            this.buttonsort.Size = new System.Drawing.Size(99, 29);
            this.buttonsort.TabIndex = 1;
            this.buttonsort.Text = "Sort";
            this.buttonsort.UseVisualStyleBackColor = true;
            this.buttonsort.Click += new System.EventHandler(this.buttonsort_Click);
            // 
            // buttonfind
            // 
            this.buttonfind.Location = new System.Drawing.Point(27, 185);
            this.buttonfind.Name = "buttonfind";
            this.buttonfind.Size = new System.Drawing.Size(99, 29);
            this.buttonfind.TabIndex = 2;
            this.buttonfind.Text = "Find";
            this.buttonfind.UseVisualStyleBackColor = true;
            this.buttonfind.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttoninfo
            // 
            this.buttoninfo.Location = new System.Drawing.Point(27, 41);
            this.buttoninfo.Name = "buttoninfo";
            this.buttoninfo.Size = new System.Drawing.Size(99, 29);
            this.buttoninfo.TabIndex = 3;
            this.buttoninfo.Text = "Info";
            this.buttoninfo.UseVisualStyleBackColor = true;
            this.buttoninfo.Click += new System.EventHandler(this.buttoninfo_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(216, 405);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(99, 29);
            this.buttonadd.TabIndex = 4;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // radioCandy
            // 
            this.radioCandy.AutoSize = true;
            this.radioCandy.BackColor = System.Drawing.Color.AntiqueWhite;
            this.radioCandy.Location = new System.Drawing.Point(141, 273);
            this.radioCandy.Name = "radioCandy";
            this.radioCandy.Size = new System.Drawing.Size(67, 20);
            this.radioCandy.TabIndex = 5;
            this.radioCandy.TabStop = true;
            this.radioCandy.Text = "Candy";
            this.radioCandy.UseVisualStyleBackColor = false;
            this.radioCandy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioChocolate
            // 
            this.radioChocolate.AutoSize = true;
            this.radioChocolate.Location = new System.Drawing.Point(12, 273);
            this.radioChocolate.Name = "radioChocolate";
            this.radioChocolate.Size = new System.Drawing.Size(99, 20);
            this.radioChocolate.TabIndex = 6;
            this.radioChocolate.TabStop = true;
            this.radioChocolate.Text = "Chocolate";
            this.radioChocolate.UseVisualStyleBackColor = true;
            this.radioChocolate.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.labelMenu.Location = new System.Drawing.Point(24, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(44, 16);
            this.labelMenu.TabIndex = 7;
            this.labelMenu.Text = "Menu";
            // 
            // labelMinSugar
            // 
            this.labelMinSugar.AutoSize = true;
            this.labelMinSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelMinSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMinSugar.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinSugar.Location = new System.Drawing.Point(24, 125);
            this.labelMinSugar.Name = "labelMinSugar";
            this.labelMinSugar.Size = new System.Drawing.Size(86, 18);
            this.labelMinSugar.TabIndex = 8;
            this.labelMinSugar.Text = "Min Sugar";
            this.labelMinSugar.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMaxSugar
            // 
            this.labelMaxSugar.AutoSize = true;
            this.labelMaxSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelMaxSugar.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxSugar.Location = new System.Drawing.Point(24, 156);
            this.labelMaxSugar.Name = "labelMaxSugar";
            this.labelMaxSugar.Size = new System.Drawing.Size(88, 18);
            this.labelMaxSugar.TabIndex = 9;
            this.labelMaxSugar.Text = "Max sugar";
            this.labelMaxSugar.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(9, 241);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(108, 16);
            this.labelAdd.TabIndex = 10;
            this.labelAdd.Text = "Add Sweetness";
            this.labelAdd.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTypeOfChocolate
            // 
            this.labelTypeOfChocolate.AutoSize = true;
            this.labelTypeOfChocolate.Location = new System.Drawing.Point(9, 322);
            this.labelTypeOfChocolate.Name = "labelTypeOfChocolate";
            this.labelTypeOfChocolate.Size = new System.Drawing.Size(134, 16);
            this.labelTypeOfChocolate.TabIndex = 11;
            this.labelTypeOfChocolate.Text = "Type Of Chocolate";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 353);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 16);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelSugar
            // 
            this.labelSugar.AutoSize = true;
            this.labelSugar.Location = new System.Drawing.Point(9, 405);
            this.labelSugar.Name = "labelSugar";
            this.labelSugar.Size = new System.Drawing.Size(49, 16);
            this.labelSugar.TabIndex = 14;
            this.labelSugar.Text = "Sugar";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Location = new System.Drawing.Point(9, 431);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(68, 16);
            this.labelCalories.TabIndex = 15;
            this.labelCalories.Text = "Calories";
            this.labelCalories.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(9, 380);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(58, 16);
            this.labelWeight.TabIndex = 16;
            this.labelWeight.Text = "Weight";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(249, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 212);
            this.listBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 428);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 350);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(131, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(789, 456);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelSugar);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTypeOfChocolate);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.labelMaxSugar);
            this.Controls.Add(this.labelMinSugar);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.radioChocolate);
            this.Controls.Add(this.radioCandy);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttoninfo);
            this.Controls.Add(this.buttonfind);
            this.Controls.Add(this.buttonsort);
            this.Controls.Add(this.buttondel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "NYGift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Button buttonsort;
        private System.Windows.Forms.Button buttonfind;
        private System.Windows.Forms.Button buttoninfo;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.RadioButton radioCandy;
        private System.Windows.Forms.RadioButton radioChocolate;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelMinSugar;
        private System.Windows.Forms.Label labelMaxSugar;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelTypeOfChocolate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSugar;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

