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
    public partial class Insert : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            string connectionstr = "Data Source = orcl; User Id = hr; Password= hr;";
            string commandstr = "select Category from Medication";
            adapter = new OracleDataAdapter(commandstr, connectionstr);
            ds = new DataSet();
            adapter.Fill(ds);
            CategorycomboBox.DataSource = ds.Tables[0].Columns["Category"];
        }

        private void InsertAdrug(object sender, EventArgs e)
        {
            if (CategorycomboBox.SelectedIndex <= -1) //nothing was selected
                MessageBox.Show("Please Select a Category!");

            else if (CategorycomboBox.SelectedIndex > -1) //somthing was selected
            {
                OracleDataAdapter adapter = new OracleDataAdapter();
                OracleCommandBuilder builder;
                string Cat_Name = CategorycomboBox.SelectedItem.ToString();
                string connectionstr = "Data Source = orcl; User Id = hr; Password= hr;";
                string commandstr = "select * from Medication where Category = :c";//bind var
                adapter.SelectCommand.Parameters.Add("c", CategorycomboBox.SelectedItem.ToString());
                adapter = new OracleDataAdapter(commandstr, connectionstr);
                ds = new DataSet();
                adapter.FillSchema(ds, SchemaType.Source, "Medication");
                adapter.Fill(ds);

                DataTable data_table;
                data_table = ds.Tables["Medication"];
                DataRow drCurrent;
                // Obtain a new DataRow object from the DataTable.
                drCurrent = data_table.NewRow();
                // Set the DataRow field values as necessary.
                drCurrent["Name"] = Drug_Name_textBox.Text;
                drCurrent["Price"] = PriceTextbox.Text;
                drCurrent["Usage"] = usageTextBox.Text;
                drCurrent["Indication"] = IndicationtextBox.Text;
                drCurrent["Precautions"] = PrecautionsTextBox.Text;
                drCurrent["Side_Effects"] = SideEffectstextBox.Text;
                drCurrent["Drug_Food_Interaction"] = FoodInteractiontextBox.Text;
                drCurrent["Drug_Drug_Interaction"] = DrugInteractiontextBox.Text;
                drCurrent["Category"] = Cat_Name;
                // Pass that new object into the Add method of the DataTable.
                data_table.Rows.Add(drCurrent);
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds);
                MessageBox.Show("The Drug was added Successfully!");
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            PharamcistOptions Home = new PharamcistOptions();
            Home.Show();
            this.Hide();
        }
    }
}
    