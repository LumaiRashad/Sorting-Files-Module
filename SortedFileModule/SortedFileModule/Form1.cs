using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace SortedFileModule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            FileOperations FO = new FileOperations();
            FO.Load();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addfrm = new AddForm();
            addfrm.Show();
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deletefrm = new DeleteForm();
            deletefrm.Show();
            this.Hide();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DisplayForm displayfrm = new DisplayForm();
            displayfrm.Show();
            this.Hide();
        }
    }
}
