using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace demo_maraphon
{
    public partial class List_of_charities : Form
    {
        public List_of_charities()
        {
            InitializeComponent();
        }
        UserControl1[] ctl;
       // public static string connectionString = "Data Source=LAPTOP-EGMGP0FI;Initial Catalog=g463_zhmurov_demo;Integrated Security=True";
        //private SqlConnection myCon;

        private void List_of_charities_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.Charity". При необходимости она может быть перемещена или удалена.
            // this.charityTableAdapter.Fill(this.g463_zhmurov_demoDataSet.Charity);

            List <string> names = new List<string>();
            List <string> description = new List<string>();
            List <string> logo = new List<string>();

              /* myCon = new SqlConnection(connectionString);
               myCon.Open();
               string sql = "Select CharityName, CharityDescription, CharityLogo FROM Charity";
               SqlCommand command = new SqlCommand(sql, myCon);

               try
               {
                   SqlDataReader dr = command.ExecuteReader();
                   int i = 0;

                   while (dr.Read()) {
                       names.Add(dr["CharityName"].ToString());
                       description.Add( dr["CharityDescription"].ToString());
                       logo.Add(dr["CharityLogo"].ToString());
                    i++;
                   }
               }
               catch (Exception ex) {
                   MessageBox.Show(ex.Message);
               }
               */

            List<string> id = new List<string>();
            g463_zhmurov_demoDataSet.CharityDataTable charities = new g463_zhmurov_demoDataSet.CharityDataTable();
            g463_zhmurov_demoDataSetTableAdapters.CharityTableAdapter charityTableAdapter = new g463_zhmurov_demoDataSetTableAdapters.CharityTableAdapter();
            charityTableAdapter.Fill(charities);
            int k = 0;
            try
            {
                foreach (DataRow dr in charities.Rows)
                {
                    id.Add( dr["CharityId"].ToString());
                    names.Add( dr["CharityName"].ToString());
                    description.Add(dr["CharityDescription"].ToString());
                    logo.Add( dr["CharityLogo"].ToString());
                    k++;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            ctl = new UserControl1[names.Count];

            for (int i = 0; i < names.Count; i++) {
                ctl[i] = new UserControl1();
                ctl[i].setup(logo[i].ToString(), names[i].ToString(), description[i].ToString());
                if (i == 0)
                {
                    ctl[i].Top = 300;
                }
                else {
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

        private void List_of_charities_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Find_out_more_information"].Show();
        }

        
    }
}
