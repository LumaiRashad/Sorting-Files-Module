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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
           
            FileOperations FO = new FileOperations();
            try
            {
                Employee emp = new Employee();
                emp.FName = FName_txt.Text;
                emp.LName = LName_text.Text;
                emp.Salary = Int64.Parse(Salary_text.Text);
                emp.Phone = Int64.Parse(Phone_text.Text);
                emp.SSN = Int64.Parse(SSN_text.Text);
                emp.Department = Department_comboBox.SelectedItem.ToString();
                if (Male_radioButton.Checked)
                {
                    emp.Gender = Male_radioButton.Text.ToString();
                }
                if (Female_radioButton.Checked)
                {
                    emp.Gender = Female_radioButton.Text.ToString();
                }
                FO.Add(emp);
                this.Hide();
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
    }
}
