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
    public partial class Inventory_receipt : Form
    {
        public static string connectionString = "Data Source=LAPTOP-EGMGP0FI;Initial Catalog=g463_zhmurov_demo;Integrated Security=True";
        private SqlConnection myCon;
        public Inventory_receipt()
        {
            InitializeComponent();
        }

        private void Inventory_receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            int RFID = int.Parse(tbRFID.Text);
            int hat = int.Parse(tbHat.Text);
            int bottle = int.Parse(tBBottle.Text);
            int tShirt = int.Parse(tbTShirt.Text);
            int booklet = int.Parse(tbBooklet.Text);

            string query = " update inventory set [RaceKitOptionA] = ([RaceKitOptionA] + " + number.ToString() + "), RaceKitOptionB = ([RaceKitOptionB] + "+ number.ToString() +"), RaceKitOptionC = ([RaceKitOptionC] + "+ number.ToString() + "), SumOfRaceKitOptions = ([SumOfRaceKitOptions] + "+ number.ToString() +") where NameOption = 'Номер';";
            query += " update inventory set [RaceKitOptionA] = ([RaceKitOptionA] + " + RFID.ToString() + "), RaceKitOptionB = ([RaceKitOptionB] + " + RFID.ToString() + "), RaceKitOptionC = ([RaceKitOptionC] + " + RFID.ToString() + "), SumOfRaceKitOptions = ([SumOfRaceKitOptions] + " + RFID.ToString() + ") where NameOption = 'RFID бр-т';";
            query += " update inventory set  RaceKitOptionB = ([RaceKitOptionB] + " + hat.ToString() + "), RaceKitOptionC = ([RaceKitOptionC] + " + hat.ToString() + "), SumOfRaceKitOptions = ([SumOfRaceKitOptions] + " + hat.ToString() + ") where NameOption = 'Бейсболка';";
            query += " update inventory set  RaceKitOptionB = ([RaceKitOptionB] + " + bottle.ToString() + "), RaceKitOptionC = ([RaceKitOptionC] + " + bottle.ToString() + "), SumOfRaceKitOptions = ([SumOfRaceKitOptions] + " + bottle.ToString() + ") where NameOption = 'Бут. воды';";
            query += " update inventory set  RaceKitOptionC = ([RaceKitOptionC] + " + tShirt.ToString() + "), SumOfRaceKitOptions = ([SumOfRaceKitOptions] + " + tShirt.ToString() + ") where NameOption = 'Футболка';";
            query += " update inventory set  RaceKitOptionC = ([RaceKitOptionC] + " + booklet.ToString() + "), SumOfRaceKitOptions = ([SumOfRaceKitOptions] + " + booklet.ToString() + ") where NameOption = 'Сув. буклет';";


            SqlCommand command = new SqlCommand(query, myCon);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void Inventory_receipt_Load(object sender, EventArgs e)
        {
            myCon = new SqlConnection(connectionString);
            myCon.Open();

            
        }
    }
}
