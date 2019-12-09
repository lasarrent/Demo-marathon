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
    public partial class About_marathon_skills_2017 : Form
    {
        public About_marathon_skills_2017()
        {
            InitializeComponent();
        }
        UserControl2[] ctl;
        string[] arrstr = { "Marathon Skills - фестиваль бега, проводимый каждый год в разных частях мира. Может быть три зачета: Полный Марафон, Полумарафон и  забег для новичков - таким образом фестиваль подходит всем.",
        "В прошлых годах марафон был проведен в Осаке, Япония (2014); Лейпциг, Германия (2013); Ханой, Вьетнам (2012) и Йорк, Англия (2011).",
        "Этот фестиваль привлек рекордное количество бегунов со всего мира.  особое внимание будет обращено на участников из Кении и Ямайки, поскольку мы надеемся увидеть победителя 2014 года. (Эфиоп закончил гонку за 45 минут 4 секунды.)," +
        "Атмосфера праздника обещает развлечения для всех зрителей.",
        "События:",
        "- Программа 'Самба' Полный Марафон начнется в Руа-Ду-Американо в 6 утра.",
        "- Программа 'Джонго' Полумарафон начнет в 7 утра Бегуны будут стартовать от недалеко от пересечения улицы Руа Ciniciata и Авенида.",
        "- Программа 'Капоэйра' в 5 км забег для новичков начнется в 15 часов Наши новички побегут от Мемориала Унинове.",
        "Спасибо всем волонтерам, которые будут помогать нам проводить марафон!"};


        private void About_marathon_skills_2017_Load(object sender, EventArgs e)
        {
            ctl = new UserControl2[arrstr.Length];

            for (int i = 0; i < arrstr.Length; i++) {
                ctl[i] = new UserControl2();
                ctl[i].loadText(arrstr[i]);
                if (i == 0)
                {
                    ctl[i].Top = 100;
                    ctl[i].Left = 400;
                }
                else {
                    ctl[i].Top = ctl[i - 1].Top + ctl[i - 1].Height;
                    ctl[i].Left = 400;
                }
                this.Controls.Add(ctl[i]);
            }
        }

        private void About_marathon_skills_2017_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Find_out_more_information"].Show();

        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Interactive_map f_map = new Interactive_map();
            f_map.Show();
            this.Hide();
        }
    }
}
