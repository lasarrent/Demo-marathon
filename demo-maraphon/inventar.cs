using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo_maraphon
{
    public partial class inventar : Form
    {
        public static string connectionString = "Data Source=LAPTOP-EGMGP0FI;Initial Catalog=g463_zhmurov_demo;Integrated Security=True";
        private SqlConnection myCon;
        public inventar()
        {
            InitializeComponent();
        }

        private void inventar_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet1.inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.g463_zhmurov_demoDataSet1.inventory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g463_zhmurov_demoDataSet.RaceKitOptionSum". При необходимости она может быть перемещена или удалена.
            this.raceKitOptionSumTableAdapter.Fill(this.g463_zhmurov_demoDataSet.RaceKitOptionSum);

            myCon = new SqlConnection(connectionString);
            myCon.Open();

            string raceOption = "declare @countA int, @countB int, @countC int, @sumRaceKitOptions int set @countA = (select count(RaceKitOptionId) as countOfOption from Registration where RaceKitOptionId = 'A' group by RaceKitOptionID)  set @countB = (select count(RaceKitOptionId) as countOfOption from Registration where RaceKitOptionId = 'B' group by RaceKitOptionID) set @countC = (select count(RaceKitOptionId) as countOfOption from Registration where RaceKitOptionId = 'C' group by RaceKitOptionID) set @sumRaceKitOptions = @countA + @countB + @countC select top 1 @countA as RaceKitOptionCountA, @countB as RaceKitOptionCountB, @countC as RaceKitOptionCountC, @sumRaceKitOptions as SumOfRaceKitOptions from Registration group by RaceKitOptionId";
            SqlCommand command = new SqlCommand(raceOption, myCon);

            try {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read()) {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = dr["RaceKitOptionCountA"].ToString();
                    dataGridView1.Rows[0].Cells[1].Value = dr["RaceKitOptionCountB"].ToString();
                    dataGridView1.Rows[0].Cells[2].Value = dr["RaceKitOptionCountC"].ToString();
                    dataGridView1.Rows[0].Cells[3].Value = dr["SumOfRaceKitOptions"].ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventar_FormClosed(object sender, FormClosedEventArgs e)
        {
            myCon.Close();
            Application.OpenForms["Administrator_menu"].Show();
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.raceKitOptionSumTableAdapter.Fill(this.g463_zhmurov_demoDataSet.RaceKitOptionSum);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void butReceipt_Click(object sender, EventArgs e)
        {
            Inventory_receipt f_inventory_Receipt = new Inventory_receipt();
            f_inventory_Receipt.Show();
        }
    }
}
