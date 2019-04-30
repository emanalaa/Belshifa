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
    public partial class Login : Form
    {
        public static string LoggedUserEmail;
        OracleDataAdapter data_adapter;
        OracleCommandBuilder command_builder;
        DataSet DS;
        public Login()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool patient_found = false;
            bool pharmacist_found = false;
            string conn = "Data Source = orcl ; User Id = hr ; password = hr ;";
            string command = "select password from patient where e-mail = :n";
            data_adapter = new OracleDataAdapter(command, conn);
            data_adapter.SelectCommand.Parameters.Add("n", Email_textBox);
            DS = new DataSet();
            data_adapter.Fill(DS);
            if (DS.Tables[0].Rows.Count != 0)
            {
                patient_found = true;
            }
            else
            {
                command = "select password from pharmacist where username = :n";
                data_adapter = new OracleDataAdapter(command, conn);
                data_adapter.SelectCommand.Parameters.Add("n", Email_textBox);
                DS = new DataSet();
                data_adapter.Fill(DS);
                if (DS.Tables[0].Rows.Count !=0)
                {
                    pharmacist_found = true;
                }
            }
            if (patient_found)
            {
                PatientHome PH = new PatientHome();
                PH.Show();
                this.Hide();
            }
            else if (pharmacist_found)
            {
                PharamcistOptions PO = new PharamcistOptions();
                PO.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please Enter The Correct Email or Register!");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Start home = new Start();
            home.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
