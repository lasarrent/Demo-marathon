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
    public partial class Registr_for_an_event : Form
    {
        public Registr_for_an_event()
        {
            InitializeComponent();
        }
        int sum = 0;

        private void summerise() {
            sum = 0;
            if (checkBox_full.Checked) sum += 145;
            if (checkBox_half.Checked) sum += 75;
            if (checkBox_min.Checked) sum += 20;
            if (rb_b.Checked) sum += 20;
            if (rb_c.Checked) sum += 45;

            lab_sum_contribution.Text = '$' + sum.ToString();
        }

        private void Registr_for_an_event_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.g463_zhmurov_demoDataSet.Charity);

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registr_for_an_event_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void but_registration_Click(object sender, EventArgs e)
        {
            if (checkBox_min.Checked || checkBox_half.Checked || checkBox_full.Checked)
            {
                
                if (int.Parse(tb_sum.Text) < 0)
                {
                    MessageBox.Show("Сумма взноса не может быть отрицательной!", "Отрицательная сумма взноса!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                   int sum_of_contribution = int.Parse(tb_sum.Text);
                }
                lab_sum_contribution.Text = sum.ToString();
            }
            else {
                MessageBox.Show("Вы не выбрали марафон!", "Вы не выбрали марафон!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
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

        private void checkBox_full_EnabledChanged(object sender, EventArgs e)
        {
            summerise();
        }
    }
}
