using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_maraphon
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        public void setup(string bg, string s1, string s2)
        {
            try
            {

                pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\Asus\\source\\repos\\demo-maraphon\\demo-maraphon\\bin\\Debug\\marathon-skills-2016-charity-data\\marathon-skills-2016-charity-data\\" + bg);
            }
            catch (Exception ex) { pictureBox1.BackColor = Color.Gray; };
            label1.Text = s1;
            label2.Text = s2;
        }
    }
}
