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
    public partial class UpdateForm1 : Form
    {
        public UpdateForm1()
        {
            InitializeComponent();
        }

        private void Update1Button_Click(object sender, EventArgs e)
        {

            FileOperations F_O = new FileOperations();
            if (F_O.CheckFind(Int64.Parse(SSN_text.Text)))
            {
                UpdateForm2 form = new UpdateForm2();
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Not found");
        }
    }
}