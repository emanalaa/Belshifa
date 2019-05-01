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

namespace Belshifa.Patient
{
    public partial class History : Form
    {
        string orcl_conn = "Data Source = orcl ; User Id = hr ; Password = hr;";
        OracleConnection conn;

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Order ID");
            dataGridView1.Columns.Add("Total_price", "Total Price");
            dataGridView1.Columns.Add("Pharmacy_No", "Pharmacy Number");

            conn = new OracleConnection(orcl_conn);
            conn.Open();

            OracleCommand oracle_command = new OracleCommand();
            oracle_command.Connection = conn;
            oracle_command.CommandText = "select * from p_order where patient_Email =:current_user";
            oracle_command.CommandType = CommandType.Text;
            oracle_command.Parameters.Add("current_user", Login.LoggedUserEmail);

            OracleDataReader dr = oracle_command.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[3].ToString());
            }
            dr.Close();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHome home = new PatientHome();
            home.Show();
            this.Hide();
        }
    }
}
