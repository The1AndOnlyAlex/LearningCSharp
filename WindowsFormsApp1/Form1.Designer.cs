namespace WindowsFormsApp1
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
            this.button_clickme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_buttonclickcount = new System.Windows.Forms.TextBox();
            this.checkBox_trueorfalse = new System.Windows.Forms.CheckBox();
            this.textBox_trueorfalse = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox_RadioButtons = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_clickme
            // 
            this.button_clickme.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clickme.Location = new System.Drawing.Point(79, 203);
            this.button_clickme.Name = "button_clickme";
            this.button_clickme.Size = new System.Drawing.Size(140, 92);
            this.button_clickme.TabIndex = 0;
            this.button_clickme.Text = "Click Me!";
            this.button_clickme.UseVisualStyleBackColor = true;
            this.button_clickme.Click += new System.EventHandler(this.button_clickme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Counting the button clicks, shows in textbox";
            // 
            // textBox_buttonclickcount
            // 
            this.textBox_buttonclickcount.Location = new System.Drawing.Point(107, 155);
            this.textBox_buttonclickcount.Name = "textBox_buttonclickcount";
            this.textBox_buttonclickcount.ReadOnly = true;
            this.textBox_buttonclickcount.Size = new System.Drawing.Size(100, 20);
            this.textBox_buttonclickcount.TabIndex = 2;
            this.textBox_buttonclickcount.Text = "0";
            // 
            // checkBox_trueorfalse
            // 
            this.checkBox_trueorfalse.AutoSize = true;
            this.checkBox_trueorfalse.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_trueorfalse.Location = new System.Drawing.Point(418, 232);
            this.checkBox_trueorfalse.Name = "checkBox_trueorfalse";
            this.checkBox_trueorfalse.Size = new System.Drawing.Size(145, 32);
            this.checkBox_trueorfalse.TabIndex = 3;
            this.checkBox_trueorfalse.Text = "checkBox1";
            this.checkBox_trueorfalse.UseVisualStyleBackColor = true;
            this.checkBox_trueorfalse.CheckedChanged += new System.EventHandler(this.checkBox_trueorfalse_CheckedChanged);
            // 
            // textBox_trueorfalse
            // 
            this.textBox_trueorfalse.Location = new System.Drawing.Point(418, 154);
            this.textBox_trueorfalse.Name = "textBox_trueorfalse";
            this.textBox_trueorfalse.ReadOnly = true;
            this.textBox_trueorfalse.Size = new System.Drawing.Size(100, 20);
            this.textBox_trueorfalse.TabIndex = 4;
            this.textBox_trueorfalse.Text = "False";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(59, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Plant Tree";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox_RadioButtons
            // 
            this.listBox_RadioButtons.FormattingEnabled = true;
            this.listBox_RadioButtons.Location = new System.Drawing.Point(6, 99);
            this.listBox_RadioButtons.Name = "listBox_RadioButtons";
            this.listBox_RadioButtons.Size = new System.Drawing.Size(188, 212);
            this.listBox_RadioButtons.TabIndex = 6;
            this.listBox_RadioButtons.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.listBox_RadioButtons);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(578, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 332);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Plant Flower";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_trueorfalse);
            this.Controls.Add(this.checkBox_trueorfalse);
            this.Controls.Add(this.textBox_buttonclickcount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clickme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_buttonclickcount;
        private System.Windows.Forms.CheckBox checkBox_trueorfalse;
        private System.Windows.Forms.TextBox textBox_trueorfalse;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox_RadioButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

