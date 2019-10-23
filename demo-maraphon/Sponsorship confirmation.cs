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
    public partial class Sponsorship_confirmation : Form
    {

        public Sponsorship_confirmation()
        {
            InitializeComponent();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Sponsor_a_runner"].Close(); // ERROR
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Sponsor_a_runner"].Close(); // ERROR
        }

        private void Sponsorship_confirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Главное_окно_системы.ActiveForm.Show();
        }

        private void Sponsorship_confirmation_Load(object sender, EventArgs e)
        {
            Sponsor_a_runner f_own = this.Owner as Sponsor_a_runner;
            lab_sum.Text = f_own.lab_sum.Text;
            lab_fond.Text = f_own.lab_fond.Text;
            lab_run.Text = f_own.cb_runner.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Главное_окно_системы.start - DateTime.Now;
            lab_date.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут " + delta.Seconds.ToString() + " секунд до начала";
        }
    }
}
