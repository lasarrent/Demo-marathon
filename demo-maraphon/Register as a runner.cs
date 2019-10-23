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
    public partial class Register_as_a_runner : Form
    {
        public Register_as_a_runner()
        {
            InitializeComponent();
        }


        private void Register_as_a_runner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void But_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_earlier_Click(object sender, EventArgs e)
        {
            Login f_log = new Login();
            this.Close();
            f_log.Show();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            Login f_log = new Login();
            this.Close();
            f_log.Show();
        }

        private void but_new_Click(object sender, EventArgs e)
        {
            Registration_as_a_runner f_reg_run = new Registration_as_a_runner();
            this.Close();
            f_reg_run.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Главное_окно_системы.start - DateTime.Now;
            label_date.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут " + delta.Seconds.ToString() + " секунд до начала";
        }
    }
}
