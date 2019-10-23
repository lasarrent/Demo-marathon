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
    public partial class Administrator_menu : Form
    {
        public Administrator_menu()
        {
            InitializeComponent();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administrator_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
