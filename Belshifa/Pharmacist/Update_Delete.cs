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
    public partial class Update_Delete : Form
    {
        string connectionstr = "Data Source = orcl; User Id = hr; Password= hr;";

        public Update_Delete()
        {
            InitializeComponent();
        }


        private void Update_Delete_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adapter;
            DataSet ds;

            string commandstr = "select distinct Category from Medication";
            adapter = new OracleDataAdapter(commandstr, connectionstr);

            ds = new DataSet();
            adapter.Fill(ds);

            CategoryList.DataSource = ds.Tables[0];
            //CategoryList.Items.Add(ds.Tables[0]);
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        { 
            /////Disconnected Mode task 2 select all rows
            OracleDataAdapter adapter = new OracleDataAdapter();
            DataSet ds;
            string selectedcategory = CategoryList.SelectedItem.ToString();

            string commandstr = "select * from Medication where Category = :c ";//bind var
            adapter.SelectCommand.Parameters.Add("c", CategoryList.SelectedItem.ToString());
            adapter = new OracleDataAdapter(commandstr, connectionstr);
            ds = new DataSet();
            adapter.Fill(ds);
            DrugComboBox.DataSource = ds.Tables["Medication"].Columns["Name"];
        }

        private void DrugComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataAdapter adapter = new OracleDataAdapter();
            DataSet ds;
            string selectedcategory = CategoryList.SelectedItem.ToString();

            string commandstr = "select * from Medication where Name = :c";//bind var
            adapter.SelectCommand.Parameters.Add("c", DrugComboBox.SelectedItem.ToString());
            adapter = new OracleDataAdapter(commandstr, connectionstr);
            ds = new DataSet();
            adapter.Fill(ds);

            PriceTextbox.Text = ds.Tables["Medication"].Columns["Price"].ToString();
            PrecautionsTextBox.Text = ds.Tables["Medication"].Columns["Precautions"].ToString();
            usageTextBox.Text = ds.Tables["Medication"].Columns["Usage"].ToString();
            IndicationtextBox.Text = ds.Tables["Medication"].Columns["Indication"].ToString();
            FoodInteractiontextBox.Text = ds.Tables["Medication"].Columns["Drug_Food_Interaction"].ToString();
            DrugInteractiontextBox.Text = ds.Tables["Medication"].Columns["Drug_Drug_Interaction"].ToString();
            SideEffectstextBox.Text = ds.Tables["Medication"].Columns["Side_Effects"].ToString();


        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (DrugComboBox.SelectedIndex <= -1) //nothing was selected
                MessageBox.Show("Please Select a Drug to update!");
            else if (DrugComboBox.SelectedIndex > -1) //somthing was selected
            {
                string drug_name = DrugComboBox.SelectedItem.ToString();
                OracleDataAdapter adapter = new OracleDataAdapter();
                OracleCommandBuilder builder;
                DataSet ds;
                DataTable Data_table;
                DataRow drCurrent;// Obtain a new DataRow object from the DataTable.
                string connectionstr = "Data Source = orcl; User Id = hr; Password= hr;";
                string commandstr = "select * from Medication where Name = :c";//bind var
                adapter.SelectCommand.Parameters.Add("c", DrugComboBox.SelectedItem.ToString());
                adapter = new OracleDataAdapter(commandstr, connectionstr);
                ds = new DataSet();
                adapter.Fill(ds);
                adapter.FillSchema(ds, SchemaType.Source, "Medication");
                Data_table = ds.Tables["Medication"];
                //////Update
                /*
                 * To edit existing rows, obtain the appropriate DataRow object,
                 * and then provide new values for one or more columns. 
                 * You must first find the correct row, which is much easier because you loaded the schema of the table 
                 * as well as the data.
                 * the table knows which column is its primary key, and the Find method of the Rows collection is available.
                 */
                drCurrent = Data_table.Rows.Find(drug_name);//The Find method returns the DataRow object with a specific value in its primary key 
                drCurrent.BeginEdit();
                drCurrent["Price"] = PriceTextbox.Text;
                drCurrent["Usage"] = usageTextBox.Text;
                drCurrent["Indication"] = IndicationtextBox.Text;
                drCurrent["Precautions"] = PrecautionsTextBox.Text;
                drCurrent["Side_Effects"] = SideEffectstextBox.Text;
                drCurrent["Drug_Food_Interaction"] = FoodInteractiontextBox.Text;
                drCurrent["Drug_Drug_Interaction"] = DrugInteractiontextBox.Text;
                drCurrent.EndEdit();
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds);
                MessageBox.Show("The Drug Info was updated");
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (DrugComboBox.SelectedIndex <= -1) //nothing was selected
                MessageBox.Show("Please Select a Drug to delete!");

            else if (DrugComboBox.SelectedIndex > -1) //somthing was selected
            {
                string drug_name = DrugComboBox.SelectedItem.ToString();
                OracleDataAdapter adapter = new OracleDataAdapter();
                OracleCommandBuilder builder;
                DataSet ds;
                DataTable Data_table;
                DataRow drCurrent;// Obtain a new DataRow object from the DataTable.
                string commandstr = "select * from Medication where Name = :c";//bind var
                adapter.SelectCommand.Parameters.Add("c", DrugComboBox.SelectedItem.ToString());
                adapter = new OracleDataAdapter(commandstr, connectionstr);
                ds = new DataSet();
                adapter.Fill(ds);
                adapter.FillSchema(ds, SchemaType.Source, "Medication");
                Data_table = ds.Tables["Medication"];
                drCurrent =Data_table.Rows.Find(drug_name);
                drCurrent.Delete();
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds);
                MessageBox.Show("The drug was successfully deleted!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            PharamcistOptions Home = new PharamcistOptions();
            Home.Show();
            this.Hide();
        }
    }
}