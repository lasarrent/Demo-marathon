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
    public partial class Runner_menu : Form
    {
        public Runner_menu()
        {
            InitializeComponent();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Runner_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void but_contacts_Click(object sender, EventArgs e)
        {
            contacts f_contacts = new contacts();
            f_contacts.Show();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            Edit_runner_profile f_edit = new Edit_runner_profile();
            f_edit.Show();
        }
    }
}
