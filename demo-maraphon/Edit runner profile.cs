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
    public partial class Edit_runner_profile : Form
    {
        public Edit_runner_profile()
        {
            InitializeComponent();
        }
        DateTime date_now = DateTime.Now;

        Image image;
        string user_email = Login.email;
        string password;
        string fName;
        string lName;
        string photo;
        string role;

        string gender;
        string date_of_born;
        string countryCode;

        g463_zhmurov_demoDataSet.UserDataTable userDataTable = new g463_zhmurov_demoDataSet.UserDataTable();
        g463_zhmurov_demoDataSetTableAdapters.UserTableAdapter userTableAdapter = new g463_zhmurov_demoDataSetTableAdapters.UserTableAdapter();

        g463_zhmurov_demoDataSet.Runner1DataTable runnerDataTable = new g463_zhmurov_demoDataSet.Runner1DataTable();
        g463_zhmurov_demoDataSetTableAdapters.Runner1TableAdapter runnerTableAdapter = new g463_zhmurov_demoDataSetTableAdapters.Runner1TableAdapter();

        public static bool is_valid_password(string password)
        {
            string pattern = "(?=.*[0-9])(?=.*[a-z])(?=.*[@!#$%^]).{6,}";
            Match is_match = Regex.Match(password, pattern);
            if (is_match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Edit_runner_profile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.g463_zhmurov_demoDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.g463_zhmurov_demoDataSet.Gender);

            lab_email.Text = user_email;

            DataRow[] dr;

            userTableAdapter.Fill(userDataTable);
            dr = userDataTable.Select("[Email] = '" + user_email + "'");

            var cell = dr[0].ItemArray;
            password = cell[1].ToString();
            tb_pass.Text = password;
            tb_repass.Text = password;

            fName = cell[2].ToString();
            tb_firstName.Text = fName;

            lName = cell[3].ToString();
            tb_name.Text = lName;

            role = cell[4].ToString();

            photo = cell[5].ToString();
            tb_photoName.Text = photo;

            runnerTableAdapter.Fill(runnerDataTable);
            dr = runnerDataTable.Select("[Email] = '" + user_email + "'");
            cell = dr[0].ItemArray;
            gender = cell[2].ToString();
            cb_gender.SelectedValue = gender;
            date_of_born = cell[3].ToString();
            dtp_yearBorn.Value = DateTime.Parse(date_of_born);
            countryCode = cell[4].ToString();
            cb_country.SelectedValue = countryCode;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = Главное_окно_системы.start - DateTime.Now;
            label_date.Text = delta.Days.ToString() + " дней " + delta.Hours.ToString() + " часов " + delta.Minutes.ToString() + " минут " + delta.Seconds.ToString() + " секунд до начала";
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text == "Пароль" || tb_repass.Text == "Повторите пароль" || tb_firstName.Text == "Имя" || tb_name.Text == "Фамилия" || cb_gender.Text == "" || tb_photoName.Text == "Photo_log.jpg" || cb_gender.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Не все поля заполнены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (is_valid_password(tb_pass.Text) == false)
                {
                    MessageBox.Show("Пароль должен содержать 1 строчную, 1 цифру и хотя бы один из символов: @!#$%^", "Неверный формат пароля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (tb_pass.Text != tb_repass.Text)
                {
                    MessageBox.Show("Пароли не совпадают", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (date_now.Year - dtp_yearBorn.Value.Year < 10 || dtp_yearBorn.Value.Year > date_now.Year)
                {
                    MessageBox.Show("Дата должна соответствовать требованиям: участнику не может быть менее 10 лет; Дата не может быть больше текущей!", "Некорректная дата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    try
                    {
                       // userTableAdapter.Adapter.UpdateCommand = "update [User] set [Password] = '" + tb_pass.Text + "' [FirstName] = '" + tb_firstName.Text + "' where [Email] ='"+ user_email + "'";
                        userTableAdapter.Update(user_email, tb_pass.Text, tb_firstName.Text, tb_name.Text, role, tb_photoName.Text, user_email);
                        
                        MessageBox.Show("OK");
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void but_view_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Файлы изображений | *.bmp; *.jpg; *.png";
            if (opf.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                image = Image.FromFile(opf.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка чтения картинки");
                return;
            }
            pic_photo.BackgroundImage = image;
            tb_photoName.Text = opf.SafeFileName.ToString();
        }
    }
}
