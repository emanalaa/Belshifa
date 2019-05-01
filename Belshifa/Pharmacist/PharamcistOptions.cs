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
    public partial class PharamcistOptions : Form
    {
        string connectionstr = "Data Source = orcl; User Id = hr; Password= hr;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public PharamcistOptions()
        {
            InitializeComponent();
        }

        private void PharamcistOptions_Load(object sender, EventArgs e)
        {
            string commandstr = "select * from Medication";
            adapter = new OracleDataAdapter(commandstr, connectionstr);

            ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Changes Saved");
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.LoggedUserEmail = "";
            Start home = new Start();
            home.Show();
            this.Hide();
        }
    }
}
