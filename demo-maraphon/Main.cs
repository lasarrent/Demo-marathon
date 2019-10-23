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
    public partial class Главное_окно_системы : Form
    {
        public static DateTime start = new DateTime(2019, 11, 24, 06, 0, 0);
        public Главное_окно_системы()
        {
            InitializeComponent();
        }

        private void Главное_окно_системы_Load(object sender, EventArgs e)
        {
            
        }

        private void but_sponsor_Click(object sender, EventArgs e)
        {
            Sponsor_a_runner f_sponsor = new Sponsor_a_runner();
            f_sponsor.Show();
            this.Hide();
        }

        private void But_runner_Click(object sender, EventArgs e)
        {
            Register_as_a_runner f_runner = new Register_as_a_runner();
            f_runner.Show();
            this.Hide();
        }

        private void but_info_Click(object sender, EventArgs e)
        {
            Find_out_more_information f_info = new Find_out_more_information();
            f_info.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Главное_окно_системы.start - DateTime.Now;
            label4.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут " + delta.Seconds.ToString() + " секунд до начала";
        }

        private void but_log_Click(object sender, EventArgs e)
        {
            Login f_login = new Login();
            f_login.Show();
            this.Hide();
        }
    }
}
