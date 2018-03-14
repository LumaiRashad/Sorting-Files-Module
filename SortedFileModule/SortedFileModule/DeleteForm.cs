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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to delete this employee?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    FileOperations F_O = new FileOperations();
                    F_O.Delete(Int64.Parse(SSN_text.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
