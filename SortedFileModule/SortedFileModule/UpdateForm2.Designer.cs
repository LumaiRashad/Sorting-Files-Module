namespace SortedFileModule
{
    partial class UpdateForm2
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SSN_text = new System.Windows.Forms.TextBox();
            this.FName_text = new System.Windows.Forms.TextBox();
            this.LName_text = new System.Windows.Forms.TextBox();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.Salary_text = new System.Windows.Forms.TextBox();
            this.Male_radioButton = new System.Windows.Forms.RadioButton();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.Department_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FName:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salary:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(49, 299);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(83, 28);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SSN_text
            // 
            this.SSN_text.Location = new System.Drawing.Point(99, 16);
            this.SSN_text.Name = "SSN_text";
            this.SSN_text.Size = new System.Drawing.Size(112, 20);
            this.SSN_text.TabIndex = 8;
            this.SSN_text.TextChanged += new System.EventHandler(this.SSN_text_TextChanged);
            // 
            // FName_text
            // 
            this.FName_text.Location = new System.Drawing.Point(104, 49);
            this.FName_text.Name = "FName_text";
            this.FName_text.Size = new System.Drawing.Size(106, 20);
            this.FName_text.TabIndex = 9;
            // 
            // LName_text
            // 
            this.LName_text.Location = new System.Drawing.Point(110, 88);
            this.LName_text.Name = "LName_text";
            this.LName_text.Size = new System.Drawing.Size(100, 20);
            this.LName_text.TabIndex = 10;
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(104, 231);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(101, 20);
            this.Phone_text.TabIndex = 12;
            // 
            // Salary_text
            // 
            this.Salary_text.Location = new System.Drawing.Point(105, 264);
            this.Salary_text.Name = "Salary_text";
            this.Salary_text.Size = new System.Drawing.Size(100, 20);
            this.Salary_text.TabIndex = 13;
            // 
            // Male_radioButton
            // 
            this.Male_radioButton.AutoSize = true;
            this.Male_radioButton.Location = new System.Drawing.Point(89, 137);
            this.Male_radioButton.Name = "Male_radioButton";
            this.Male_radioButton.Size = new System.Drawing.Size(47, 17);
            this.Male_radioButton.TabIndex = 15;
            this.Male_radioButton.TabStop = true;
            this.Male_radioButton.Text = "Male";
            this.Male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.Location = new System.Drawing.Point(182, 137);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Female_radioButton.TabIndex = 16;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Department_text
            // 
            this.Department_text.Location = new System.Drawing.Point(105, 186);
            this.Department_text.Name = "Department_text";
            this.Department_text.Size = new System.Drawing.Size(100, 20);
            this.Department_text.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Department_text);
            this.Controls.Add(this.Female_radioButton);
            this.Controls.Add(this.Male_radioButton);
            this.Controls.Add(this.Salary_text);
            this.Controls.Add(this.Phone_text);
            this.Controls.Add(this.LName_text);
            this.Controls.Add(this.FName_text);
            this.Controls.Add(this.SSN_text);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm2";
            this.Text = "UpdateForm2";
            this.Load += new System.EventHandler(this.UpdateForm2_Load);
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
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox SSN_text;
        private System.Windows.Forms.TextBox FName_text;
        private System.Windows.Forms.TextBox LName_text;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.TextBox Salary_text;
        private System.Windows.Forms.RadioButton Male_radioButton;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.TextBox Department_text;
        private System.Windows.Forms.Button button1;
    }
}