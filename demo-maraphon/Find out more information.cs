using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_maraphon
{
    public partial class Find_out_more_information : Form
    {
        public Find_out_more_information()
        {
            InitializeComponent();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_out_more_information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List_of_charities f_charities = new List_of_charities();
            f_charities.Show();
            this.Hide();
        }
    }
}
