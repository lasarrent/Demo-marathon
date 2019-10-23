using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace demo_maraphon
{
    public partial class Registration_as_a_runner : Form
    {
        Image image;
        public Registration_as_a_runner()
        {
            InitializeComponent();
        }

        DateTime date_now = DateTime.Now;

        public static bool is_valid_email (string email) {
            string pattern = "[0-9a-zA-Z\\-_\\.]+@[a-zA-Z0-9\\-_\\.]+.[a-z]{2,6}";
            Match is_match = Regex.Match(email, pattern);
            if (is_match.Success)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool is_valid_password(string password) {
            string pattern = "(?=.*[0-9])(?=.*[a-z])(?=.*[@!#$%^]).{6,}";
            Match is_match = Regex.Match(password, pattern);
            if (is_match.Success)
            {
                return true;
            }
            else {
                return false;
            }
        }
        
        private void tb_email_Enter(object sender, EventArgs e)
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

        private void tb_email_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "") t.Text = (string)t.Tag;
            t.ForeColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Главное_окно_системы.start - DateTime.Now;
            label_date.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут " + delta.Seconds.ToString() + " секунд до начала";
        }

        private void but_registration_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "Email" || tb_pass.Text == "Пароль" || tb_repass.Text == "Повторите пароль" || tb_name.Text == "Имя" || tb_firstName.Text == "Фамилия" || cb_gender.Text == "" || tb_photoName.Text == "Photo_log.jpg" || cb_gender.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (is_valid_email(tb_email.Text) == false)
                {
                    MessageBox.Show( "Email должен соответствовать формату x@x.x", "Некорректно введен email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    if (tb_pass.Text != tb_repass.Text)
                    {
                        MessageBox.Show("Пароли не совпадают", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (is_valid_password(tb_pass.Text) == false)
                    {
                        MessageBox.Show("Пароль должен содержать 1 строчную, 1 цифру и хотя бы один из символов: @!#$%^", "Неверный формат пароля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (date_now.Year - dtp_yearBorn.Value.Year < 10 || dtp_yearBorn.Value.Year > date_now.Year ) {
                        MessageBox.Show( "Дата должна соответствовать требованиям: участнику не может быть менее 10 лет; Дата не может быть больше текущей!", "Некорректная дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Registr_for_an_event f_evt = new Registr_for_an_event();
                        this.Close();
                        f_evt.Show();
                    }
                }
                
            }
        }

        private void Registration_as_a_runner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.g463_zhmurov_demoDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.g463_zhmurov_demoDataSet.Gender);

        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_as_a_runner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = Application.OpenForms[0];
            main.Show();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_view_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Файлы изображений | *.bmp; *.jpg; *.png";
            if (opf.ShowDialog() != DialogResult.OK) {
                return;   
            }
            try
            {
                image = Image.FromFile(opf.FileName);
            }
            catch (OutOfMemoryException ex) {
                MessageBox.Show(ex.Message, "Ошибка чтения картинки");
                return;
            }
            pic_photo.BackgroundImage = image;
            tb_photoName.Text = opf.SafeFileName.ToString();
        }
    }
}
