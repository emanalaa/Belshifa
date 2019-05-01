using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Belshifa
{
    public struct contain //l mafrood enha mtshafa f kol el forms
    {
        public string name;
        public int ID;
        public int quantity;
    }
  

    public partial class Order : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection con;

        public int size = 0; ///msh 3rfa da mtshaf f kol el forms wla laa , bs lma bn2lo foo2 by3ml error

        public Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHome Home = new PatientHome();
            Home.Show();
            this.Hide();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select distinct category from medication";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CategoryList.Items.Add(dr[0]);
            }
            dr.Close();
        }
     
        private void AddtoCartButton_Click(object sender, EventArgs e)
        {

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            DetailsListBox.Visible = true;
        }

        private void DrugComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int price;
            string usage, indication, side_effects, drug_interaction, food_interaction;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "drug_info";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("med_name", DrugComboBox.SelectedItem.ToString());
            cmd.Parameters.Add("med_price", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("med_usage", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("med_indication", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("med_side", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("med_drug", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("med_food", OracleDbType.Varchar2, ParameterDirection.Output);

            cmd.ExecuteNonQuery();  // btrg3 -1 lw fi rows unaffected bs ana hna b3ml select fa mafrood msh h7tgha

            price = Convert.ToInt32(cmd.Parameters["med_price"].Value.ToString());
            usage = cmd.Parameters["med_usage"].Value.ToString();
            indication = cmd.Parameters["med_indication"].Value.ToString();
            side_effects = cmd.Parameters["med_side"].Value.ToString();
            drug_interaction = cmd.Parameters["med_drug"].Value.ToString();
            food_interaction = cmd.Parameters["med_food"].Value.ToString();
            MessageBox.Show("5");

            PriceTextbox.Text = price.ToString();
            DetailsListBox.Items.Add(usage);
            DetailsListBox.Items.Add(indication);
            DetailsListBox.Items.Add(side_effects);
            DetailsListBox.Items.Add(drug_interaction);
            DetailsListBox.Items.Add(food_interaction);
            MessageBox.Show("6");

            contain[] arr = new contain[100];
            arr[size].name = DrugComboBox.SelectedItem.ToString();
            arr[size].ID = size;
            arr[size].quantity = Convert.ToInt32(QuantityDomain.Items.ToString()); /////msh 3rfa hya di el property el sa7 wla laa 3shan akhod el value
            size++;
            MessageBox.Show("7");

            label2.Visible = true;
            label4.Visible = true;
            PriceTextbox.Visible = true;
            QuantityDomain.Visible = true;
            DetailsButton.Visible = true;
            MessageBox.Show("8");

        }

        private void CategoryList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DrugComboBox.Items.Clear();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NAME from MEDICATION where category =: cat";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("cat", CategoryList.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DrugComboBox.Items.Add(dr[0]);
            }
            dr.Close();

            label3.Visible = true;
            DrugComboBox.Visible = true;
        }
    }
}
