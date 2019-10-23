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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string email;
        string password;
        g463_zhmurov_demoDataSet.UserDataTable userDataTable = new g463_zhmurov_demoDataSet.UserDataTable();
        g463_zhmurov_demoDataSetTableAdapters.UserTableAdapter userTableAdapter = new g463_zhmurov_demoDataSetTableAdapters.UserTableAdapter();
        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.OpenForms[0].Show();
           // this.Close();
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

        private void but_login_Click(object sender, EventArgs e)
        {
            email = tb_email.Text;
            password = tb_pass.Text;

            DataRow[] dr;
            userTableAdapter.Fill(userDataTable);
            dr = userDataTable.Select("[Email] = '" + email + "'");
            if (email == "Enter your email address" || password == "Enter your password")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dr.Count() == 0)
                {
                    MessageBox.Show("Неверный логин!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var cell = dr[0].ItemArray;
                    string passwordAuth = cell[1].ToString();
                    if (passwordAuth != password)
                    {
                        MessageBox.Show("Неверное введен пароль!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        if (cell[4].ToString() == "R") {
                            MessageBox.Show("Вы бегун!","Auth success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Runner_menu f_runner_menu = new Runner_menu();
                            this.Close();
                            f_runner_menu.Show();
                        }
                        if (cell[4].ToString() == "C")
                        {
                            MessageBox.Show("Вы координатор!", "Auth success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Coordinator_menu f_coordinator_menu = new Coordinator_menu();
                            this.Close();
                            f_coordinator_menu.Show();
                        }
                        if (cell[4].ToString() == "A")
                        {
                            MessageBox.Show("Вы администратор!", "Auth success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Administrator_menu f_admin_menu = new Administrator_menu();
                            this.Close();
                            f_admin_menu.Show();
                        }
                    }
                }
            }
            
            
           // MessageBox.Show(cell[4].ToString());



        }
    }
}
