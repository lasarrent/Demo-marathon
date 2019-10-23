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
    public partial class Sponsor_a_runner : Form
    {
        g463_zhmurov_demoDataSetTableAdapters.SponsorshipTableAdapter sponsorshipTableAdapter = new g463_zhmurov_demoDataSetTableAdapters.SponsorshipTableAdapter();
        public Sponsor_a_runner()
        {
            InitializeComponent();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
            this.Close();
        }

        private void Sponsor_a_runner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_pay_Click(object sender, EventArgs e)
        {

            DateTime t = DateTime.Now;
            int y = int.Parse(tb_year.Text);
            int m = int.Parse(tb_month.Text);
            int cvc = int.Parse(tb_cvc.Text);

            bool inv = false;
            if (t.Year >= y)
            {
                if (t.Year == y)
                {
                    if (t.Month < m) inv = true;
                }
            }
             
             else if (tb_name.Text == "Ваше имя" || tb_card.Text == "Владелец карты" || tb_number_card.MaskFull == false || tb_cvc.Text == "123" || cb_runner.Text == "") {
                inv = false;
                MessageBox.Show("Please, fill an all the fields!");
            }
           
            else
            {
                inv = true;
            }


            if (inv == false)
            {
                MessageBox.Show(inv.ToString());
            }
            else {
                int registrationId = int.Parse(cb_runner.SelectedValue.ToString());
                string sponsorName = tb_name.Text;
                int amount = int.Parse(tb_money.Text);

                //string query = "INSERT INTO Sponsorship (SponsorName, RegistrationId, Amount) values ("+ sponsorName +", "+ registrationId +", " + amount +")";
                sponsorshipTableAdapter.Insert(sponsorName, registrationId, amount);

                Sponsorship_confirmation f_confirm = new Sponsorship_confirmation();
                f_confirm.Owner = this;
                this.Hide();
                f_confirm.ShowDialog();
            }

            
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";
                
            }
            else {
                if ((string)t.Tag == t.Text) t.Text = "";
            }
            t.ForeColor = Color.Black;
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "") t.Text = (string)t.Tag;
            t.ForeColor = Color.Gray;
        }

        private void Sponsor_a_runner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet1.Runner". При необходимости она может быть перемещена или удалена.
            this.runnerTableAdapter.Fill(this.g463_zhmurov_demoDataSet1.Runner);
            
        }

        private void but_plus_Click(object sender, EventArgs e)
        {
            int money = int.Parse(tb_money.Text);
            money += 10; ;
            tb_money.Text = money.ToString();
        }

        private void but_minus_Click(object sender, EventArgs e)
        {
            int money = int.Parse(tb_money.Text);
            if (money >= 10) money -= 10;
            tb_money.Text = money.ToString();
        }

        private void tb_money_TextChanged(object sender, EventArgs e)
        {
            lab_sum.Text = "$" + tb_money.Text;
        }

        private void tb_number_card_Enter(object sender, EventArgs e)
        {
            MaskedTextBox t = (MaskedTextBox)sender;
            if (t.Tag == null)
            {
                t.Tag = t.Text;
                t.Text = "";

            }
            else
            {
                if ((string)t.Tag == t.Text) t.Text = "";
            }
            t.ForeColor = Color.Black;
        }

        private void tb_number_card_Leave(object sender, EventArgs e)
        {
            MaskedTextBox t = (MaskedTextBox)sender;
            if (t.Text == "") t.Text = (string)t.Tag;
            t.ForeColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Главное_окно_системы.start - DateTime.Now;
            lab_date.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут " + delta.Seconds.ToString() + " секунд до начала";
        }
    }
}
