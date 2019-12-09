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
    public partial class how_long_is_a_marathon : Form
    {
        public how_long_is_a_marathon()
        {
            InitializeComponent();
        }
        

        private void picF1_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picF1.BackgroundImage;
            labName.Text = labF1.Text;
            double speed = 345;
            double dist = 42;
            double time = dist / speed;
            double timeMin = time * 60;
            int outTimeHour = 0;
            int outTimeMin = (int) timeMin;
            if (timeMin > 60) {
                outTimeHour = (int) timeMin / 60;
                outTimeMin = (int)timeMin - (outTimeHour * 60);
            }
            
            string speedOut = "Максимальная скорость " + labName.Text + " " + speed.ToString() + ". Это займет " + outTimeHour.ToString() + " часов " + outTimeMin.ToString() + " минут, чтобы завершить 42km марафон.";
            labInfo.Text = speedOut;
        }

        private void picWorm_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picWorm.BackgroundImage;
            labName.Text = labWorm.Text;

            double speed = 0.03;
            double dist = 42;
            double time = dist / speed;
            double timeMin = time * 60;
            int outTimeHour = 0;
            int outTimeMin = (int)timeMin;
            if (timeMin > 60)
            {
                outTimeHour = (int)timeMin / 60;
                outTimeMin = (int)timeMin - (outTimeHour * 60);
            }

            string speedOut = "Максимальная скорость " + labName.Text + " " + speed.ToString() + ". Это займет " + outTimeHour.ToString() + " часов " + outTimeMin.ToString() + " минут, чтобы завершить 42km марафон.";
            labInfo.Text = speedOut;
        }

        private void picSloth_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picSloth.BackgroundImage;
            labName.Text = labSloth.Text;

            double speed = 0.12;
            double dist = 42;
            double time = dist / speed;
            double timeMin = time * 60;
            int outTimeHour = 0;
            int outTimeMin = (int)timeMin;
            if (timeMin > 60)
            {
                outTimeHour = (int)timeMin / 60;
                outTimeMin = (int)timeMin - (outTimeHour * 60);
            }

            string speedOut = "Максимальная скорость " + labName.Text + " " + speed.ToString() + ". Это займет " + outTimeHour.ToString() + " часов " + outTimeMin.ToString() + " минут, чтобы завершить 42km марафон.";
            labInfo.Text = speedOut;
        }

        private void picCapybara_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picCapybara.BackgroundImage;
            labName.Text = labCapybara.Text;

            double speed = 35;
            double dist = 42;
            double time = dist / speed;
            double timeMin = time * 60;
            int outTimeHour = 0;
            int outTimeMin = (int)timeMin;
            if (timeMin > 60)
            {
                outTimeHour = (int)timeMin / 60;
                outTimeMin = (int)timeMin - (outTimeHour * 60);
            }

            string speedOut = "Максимальная скорость " + labName.Text + " " + speed.ToString() + ". Это займет " + outTimeHour.ToString() + " часов " + outTimeMin.ToString() + " минут, чтобы завершить 42km марафон.";
            labInfo.Text = speedOut;
        }

        private void picAirbus_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picAirbus.BackgroundImage;
            labName.Text = labAirbus.Text;

            double length = 73;
            double distM = 42 * 1000;
            int outCount = (int) (distM / length);
            string distOut = "Длина " + labAirbus.Text + " " + length.ToString() + ". Это займет " + outCount.ToString() + " из них, чтобы покрыть расстояние в 42km марафона.";
            labInfo.Text = distOut;
        }

        private void picHavai_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picHavai.BackgroundImage;
            labName.Text = labHavai.Text;

            double length = 0.245;
            double distM = 42 * 1000;
            int outCount = (int)(distM / length);
            string distOut = "Длина " + labName.Text + " " + length.ToString() + ". Это займет " + outCount.ToString() + " из них, чтобы покрыть расстояние в 42km марафона.";
            labInfo.Text = distOut;
        }

        private void picFootball_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picFootball.BackgroundImage;
            labName.Text = labFootball.Text;

            double length = 105;
            double distM = 42 * 1000;
            int outCount = (int)(distM / length);
            string distOut = "Длина " + labName.Text + " " + length.ToString() + ". Это займет " + outCount.ToString() + " из них, чтобы покрыть расстояние в 42km марафона.";
            labInfo.Text = distOut;
        }

        private void picRonaldo_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picRonaldo.BackgroundImage;
            labName.Text = labRonaldo.Text;

            double length = 1.81;
            double distM = 42 * 1000;
            int outCount = (int)(distM / length);
            string distOut = "Длина " + labName.Text + " " + length.ToString() + ". Это займет " + outCount.ToString() + " из них, чтобы покрыть расстояние в 42km марафона.";
            labInfo.Text = distOut;
        }

        private void picBus_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picBus.BackgroundImage;
            labName.Text = labBus.Text;

            double length = 10;
            double distM = 42 * 1000;
            int outCount = (int)(distM / length);
            string distOut = "Длина " + labName.Text + " " + length.ToString() + ". Это займет " + outCount.ToString() + " из них, чтобы покрыть расстояние в 42km марафона.";
            labInfo.Text = distOut;
        }

        private void picJaguar_Click(object sender, EventArgs e)
        {
            picOut.BackgroundImage = picJaguar.BackgroundImage;
            labName.Text = labJaguar.Text;

            double speed = 80;
            double dist = 42;
            double time = dist / speed;
            double timeMin = time * 60;
            int outTimeHour = 0;
            int outTimeMin = (int)timeMin;
            if (timeMin > 60)
            {
                outTimeHour = (int)timeMin / 60;
                outTimeMin = (int)timeMin - (outTimeHour * 60);
            }

            string speedOut = "Максимальная скорость " + labName.Text + " " + speed.ToString() + ". Это займет " + outTimeHour.ToString() + " часов " + outTimeMin.ToString() + " минут, чтобы завершить 42km марафон.";
            labInfo.Text = speedOut;
        }

        private void how_long_is_a_marathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form find_out_more_info = Application.OpenForms["Find_out_more_information"];
            find_out_more_info.Show();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
