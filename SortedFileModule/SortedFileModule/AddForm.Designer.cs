namespace SortedFileModule
{
    partial class AddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SSN_text = new System.Windows.Forms.TextBox();
            this.FName_txt = new System.Windows.Forms.TextBox();
            this.LName_text = new System.Windows.Forms.TextBox();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.Salary_text = new System.Windows.Forms.TextBox();
            this.Male_radioButton = new System.Windows.Forms.RadioButton();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.Department_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salary:";
            // 
            // SSN_text
            // 
            this.SSN_text.Location = new System.Drawing.Point(82, 9);
            this.SSN_text.Name = "SSN_text";
            this.SSN_text.Size = new System.Drawing.Size(100, 20);
            this.SSN_text.TabIndex = 7;
            // 
            // FName_txt
            // 
            this.FName_txt.Location = new System.Drawing.Point(84, 41);
            this.FName_txt.Name = "FName_txt";
            this.FName_txt.Size = new System.Drawing.Size(97, 20);
            this.FName_txt.TabIndex = 8;
            this.FName_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LName_text
            // 
            this.LName_text.Location = new System.Drawing.Point(85, 85);
            this.LName_text.Name = "LName_text";
            this.LName_text.Size = new System.Drawing.Size(96, 20);
            this.LName_text.TabIndex = 9;
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(82, 230);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(98, 20);
            this.Phone_text.TabIndex = 10;
            this.Phone_text.TextChanged += new System.EventHandler(this.Phone_text_TextChanged);
            // 
            // Salary_text
            // 
            this.Salary_text.Location = new System.Drawing.Point(87, 275);
            this.Salary_text.Name = "Salary_text";
            this.Salary_text.Size = new System.Drawing.Size(95, 20);
            this.Salary_text.TabIndex = 11;
            // 
            // Male_radioButton
            // 
            this.Male_radioButton.AutoSize = true;
            this.Male_radioButton.Location = new System.Drawing.Point(95, 130);
            this.Male_radioButton.Name = "Male_radioButton";
            this.Male_radioButton.Size = new System.Drawing.Size(47, 17);
            this.Male_radioButton.TabIndex = 12;
            this.Male_radioButton.TabStop = true;
            this.Male_radioButton.Text = "Male";
            this.Male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.Location = new System.Drawing.Point(197, 130);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Female_radioButton.TabIndex = 13;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Department_comboBox
            // 
            this.Department_comboBox.FormattingEnabled = true;
            this.Department_comboBox.Items.AddRange(new object[] {
            "Bioinformatics",
            "Software",
            "IT",
            "SC",
            "IS",
            "CS"});
            this.Department_comboBox.Location = new System.Drawing.Point(86, 172);
            this.Department_comboBox.Name = "Department_comboBox";
            this.Department_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Department_comboBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "SSN:";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(57, 317);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(85, 23);
            this.Add_button.TabIndex = 16;
            this.Add_button.Text = "Add Employee";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Department_comboBox);
            this.Controls.Add(this.Female_radioButton);
            this.Controls.Add(this.Male_radioButton);
            this.Controls.Add(this.Salary_text);
            this.Controls.Add(this.Phone_text);
            this.Controls.Add(this.LName_text);
            this.Controls.Add(this.FName_txt);
            this.Controls.Add(this.SSN_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SSN_text;
        private System.Windows.Forms.TextBox FName_txt;
        private System.Windows.Forms.TextBox LName_text;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.TextBox Salary_text;
        private System.Windows.Forms.RadioButton Male_radioButton;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.ComboBox Department_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button button1;
    }
}