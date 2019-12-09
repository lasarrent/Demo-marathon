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
    public partial class Charity_manager : Form
    {
        public Charity_manager()
        {
            InitializeComponent();
        }
        UserControl1[] ctl;

        private void Charity_manager_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            List<string> description = new List<string>();
            List<string> logo = new List<string>();

            List<string> id = new List<string>();
            g463_zhmurov_demoDataSet.CharityDataTable charities = new g463_zhmurov_demoDataSet.CharityDataTable();
            g463_zhmurov_demoDataSetTableAdapters.CharityTableAdapter charityTableAdapter = new g463_zhmurov_demoDataSetTableAdapters.CharityTableAdapter();
            charityTableAdapter.Fill(charities);
            int k = 0;
            try
            {
                foreach (DataRow dr in charities.Rows)
                {
                    id.Add(dr["CharityId"].ToString());
                    names.Add(dr["CharityName"].ToString());
                    description.Add(dr["CharityDescription"].ToString());
                    logo.Add(dr["CharityLogo"].ToString());
                    k++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ctl = new UserControl1[names.Count];

            for (int i = 0; i < names.Count; i++)
            {
                ctl[i] = new UserControl1();
                ctl[i].setup(logo[i].ToString(), names[i].ToString(), description[i].ToString());
                if (i == 0)
                {
                    ctl[i].Top = 300;
                }
                else
                {
                    ctl[i].Top = ctl[i - 1].Top + ctl[i].Height;
                }
                ctl[i].Left = 100;
                this.Controls.Add(ctl[i]);
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
