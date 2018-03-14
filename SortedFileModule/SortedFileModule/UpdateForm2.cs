using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedFileModule
{
    public partial class UpdateForm2 : Form
    {
        public UpdateForm2()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.FName = FName_text.Text;
                emp.LName = LName_text.Text;
                emp.SSN = Int64.Parse(SSN_text.Text);
                emp.Department = Department_text.Text;
                emp.Salary = Int64.Parse(Salary_text.Text);
                emp.Phone = Int64.Parse(Phone_text.Text);
                if (Female_radioButton.Checked)
                {
                    emp.Gender = Female_radioButton.Text;
                }
                else if (Male_radioButton.Checked)
                {
                    emp.Gender = Male_radioButton.Text;
                }

                DialogResult result = MessageBox.Show("Are you want to Updata?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    FileOperations F_O = new FileOperations();
                    F_O.Update(F_O.GetSSN(), emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void SSN_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateForm2_Load(object sender, EventArgs e)
        {
            FileOperations FO = new FileOperations();
           // UpdateForm1 frm = new UpdateForm1();
            Employee emp = FO.FindEmployee(FO.GetSSN());
            SSN_text.Text = emp.SSN.ToString();
            FName_text.Text = emp.FName;
            LName_text.Text = emp.LName;
            Department_text.Text = emp.Department;
            Phone_text.Text = emp.Phone.ToString();
            if (emp.Salary != 0)
            {
                Salary_text.Text = emp.Salary.ToString();
            }
            if (emp.Phone != 0)
            {
                Phone_text.Text = emp.Phone.ToString();
            }
            if (emp.Gender == "Male")
            {
                this.Male_radioButton.Checked = true;
               
            }
            else if (emp.Gender == "Female")
            {
                this.Female_radioButton.Checked = true;
            }
           
        }
    }
}
