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
    public partial class Interactive_map : Form
    {
        public Interactive_map()
        {
            InitializeComponent();
        }
        PictureBox[] pic = new PictureBox[5];
        Label[] lab = new Label[5];

        private void Checkpoint1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }
            
            labCheckpoint.Text = "CheckPoint 1";
            labLandmark.Text = "Landmark";
            labLandmarkName.Text = "Avenida Rudge";
            labServices.Text = "Services:";
            
            string[] services = { "Drinks", "Energy Bars", "Toilets", "Information", "Medical" };
            
            for (int i = 0; i < 2; i++) {
                pic[i] = new System.Windows.Forms.PictureBox();
                pic[i].Location = new System.Drawing.Point(700, 220 + i * 50 + 60);
                pic[i].Size = new Size(50, 50);
                pic[i].Name = "PictureBoxIcons" + i.ToString();
                pic[i].Image = Image.FromFile("C:\\Users\\Asus\\Documents\\Конспекты 4-й курс\\демо-экзамен\\TP09_resources\\WSR2016_TP09_ресурсы_сессия_3\\marathon-skills-2016-interactive-map-data\\map-icons\\map-icon-"+ i.ToString() +".png");
                pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pic[i]);
                lab[i] = new System.Windows.Forms.Label();
                lab[i].Text = services[i];
                lab[i].Location = new System.Drawing.Point(800, 220 + i * 50 + 80);
                Controls.Add(lab[i]);

            }
        }

        private void Interactive_map_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["About_marathon_skills_2017"].Show();
        }

        private void Checkpoint2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }

            labCheckpoint.Text = "CheckPoint 2";
            labLandmark.Text = "Landmark";
            labLandmarkName.Text = "Theatro Municipal";
            labServices.Text = "Services:";

            string[] services = { "Drinks", "Energy Bars", "Toilets", "Information", "Medical" };

            for (int i = 0; i < 5; i++)
            {
                pic[i] = new System.Windows.Forms.PictureBox();
                pic[i].Location = new System.Drawing.Point(700, 220 + i * 50 + 60);
                pic[i].Size = new Size(50, 50);
                pic[i].Name = "PictureBoxIcons" + i.ToString();
                pic[i].Image = Image.FromFile("C:\\Users\\Asus\\Documents\\Конспекты 4-й курс\\демо-экзамен\\TP09_resources\\WSR2016_TP09_ресурсы_сессия_3\\marathon-skills-2016-interactive-map-data\\map-icons\\map-icon-" + i.ToString() + ".png");
                pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pic[i]);
                lab[i] = new System.Windows.Forms.Label();
                lab[i].Text = services[i];
                lab[i].Location = new System.Drawing.Point(800, 220 + i * 50 + 80);
                Controls.Add(lab[i]);

            }
        }

        private void Checkpoint3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }

            labCheckpoint.Text = "CheckPoint 3";
            labLandmark.Text = "Landmark";
            labLandmarkName.Text = "Parque do Ibirapuera";
            labServices.Text = "Services:";

            string[] services = { "Drinks", "Energy Bars", "Toilets", "Information", "Medical" };

            for (int i = 0; i < 3; i++)
            {
                pic[i] = new System.Windows.Forms.PictureBox();
                pic[i].Location = new System.Drawing.Point(700, 220 + i * 50 + 60);
                pic[i].Size = new Size(50, 50);
                pic[i].Name = "PictureBoxIcons" + i.ToString();
                pic[i].Image = Image.FromFile("C:\\Users\\Asus\\Documents\\Конспекты 4-й курс\\демо-экзамен\\TP09_resources\\WSR2016_TP09_ресурсы_сессия_3\\marathon-skills-2016-interactive-map-data\\map-icons\\map-icon-" + i.ToString() + ".png");
                pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pic[i]);
                lab[i] = new System.Windows.Forms.Label();
                lab[i].Text = services[i];
                lab[i].Location = new System.Drawing.Point(800, 220 + i * 50 + 80);
                Controls.Add(lab[i]);

            }

        }

        private void Checkpoint4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }

            labCheckpoint.Text = "CheckPoint 4";
            labLandmark.Text = "Landmark";
            labLandmarkName.Text = "Jardim Luzitania";
            labServices.Text = "Services:";

            string[] services = { "Drinks", "Energy Bars", "Toilets", "Information", "Medical" };

            for (int i = 0; i < 5; i++)
            {
                if (i == 3) continue;
                pic[i] = new System.Windows.Forms.PictureBox();
                pic[i].Location = new System.Drawing.Point(700, 220 + i * 50 + 60);
                pic[i].Size = new Size(50, 50);
                pic[i].Name = "PictureBoxIcons" + i.ToString();
                pic[i].Image = Image.FromFile("C:\\Users\\Asus\\Documents\\Конспекты 4-й курс\\демо-экзамен\\TP09_resources\\WSR2016_TP09_ресурсы_сессия_3\\marathon-skills-2016-interactive-map-data\\map-icons\\map-icon-" + i.ToString() + ".png");
                pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pic[i]);
                lab[i] = new System.Windows.Forms.Label();
                lab[i].Text = services[i];
                lab[i].Location = new System.Drawing.Point(800, 220 + i * 50 + 80);
                Controls.Add(lab[i]);

            }
        }

        private void Checkpoint5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }

            labCheckpoint.Text = "CheckPoint 5";
            labLandmark.Text = "Landmark";
            labLandmarkName.Text = "Iguatemi";
            labServices.Text = "Services:";

            string[] services = { "Drinks", "Energy Bars", "Toilets", "Information", "Medical" };

            for (int i = 0; i < 4; i++)
            {
                pic[i] = new System.Windows.Forms.PictureBox();
                pic[i].Location = new System.Drawing.Point(700, 220 + i * 50 + 60);
                pic[i].Size = new Size(50, 50);
                pic[i].Name = "PictureBoxIcons" + i.ToString();
                pic[i].Image = Image.FromFile("C:\\Users\\Asus\\Documents\\Конспекты 4-й курс\\демо-экзамен\\TP09_resources\\WSR2016_TP09_ресурсы_сессия_3\\marathon-skills-2016-interactive-map-data\\map-icons\\map-icon-" + i.ToString() + ".png");
                pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pic[i]);
                lab[i] = new System.Windows.Forms.Label();
                lab[i].Text = services[i];
                lab[i].Location = new System.Drawing.Point(800, 220 + i * 50 + 80);
                Controls.Add(lab[i]);

            }
        }

        private void Checkpoint6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }

            labCheckpoint.Text = "CheckPoint 6";
            labLandmark.Text = "Landmark";
            labLandmarkName.Text = "Rua Lisboa";
            labServices.Text = "Services:";

            string[] services = { "Drinks", "Energy Bars", "Toilets", "Information", "Medical" };

            for (int i = 0; i < 3; i++)
            {
                pic[i] = new System.Windows.Forms.PictureBox();
                pic[i].Location = new System.Drawing.Point(700, 220 + i * 50 + 60);
                pic[i].Size = new Size(50, 50);
                pic[i].Name = "PictureBoxIcons" + i.ToString();
                pic[i].Image = Image.FromFile("C:\\Users\\Asus\\Documents\\Конспекты 4-й курс\\демо-экзамен\\TP09_resources\\WSR2016_TP09_ресурсы_сессия_3\\marathon-skills-2016-interactive-map-data\\map-icons\\map-icon-" + i.ToString() + ".png");
                pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(pic[i]);
                lab[i] = new System.Windows.Forms.Label();
                lab[i].Text = services[i];
                lab[i].Location = new System.Drawing.Point(800, 220 + i * 50 + 80);
                Controls.Add(lab[i]);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Controls.Remove(pic[i]);
                Controls.Remove(lab[i]);
            }

            labCheckpoint.Text = "Race Start";
            labLandmark.Text = "MArathon Name";
            labLandmarkName.Text = "Samba Full Marathon";
            labServices.Text = "Distance: 42km";
        }
    }
}
