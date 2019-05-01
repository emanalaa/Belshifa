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
        string conn = "Data Source = orcl ; User Id = hr ; password = hr ;";
        public static string LoggedUserEmail;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool patient_found = false;
            bool pharmacist_found = false;

            string command = "select * from patient where email =:n and password =:p";

            OracleDataAdapter data_adapter = new OracleDataAdapter(command, conn);
            data_adapter.SelectCommand.Parameters.Add("n", Email_textBox.Text);
            data_adapter.SelectCommand.Parameters.Add("p", password_textBox.Text);

            DataSet DS = new DataSet();
            data_adapter.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                patient_found = true;
            }
            else
            {
                command = "select * from pharmacist where USERNAME = :n and password =:p";

                data_adapter = new OracleDataAdapter(command, conn);
                data_adapter.SelectCommand.Parameters.Add("n", Email_textBox.Text);
                data_adapter.SelectCommand.Parameters.Add("p", password_textBox.Text);

                DS = new DataSet();
                data_adapter.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    pharmacist_found = true;
                }
            }
            if (patient_found)
            {
                LoggedUserEmail = Email_textBox.Text;
                PatientHome PH = new PatientHome();
                PH.Show();
                this.Hide();
            }
            else if (pharmacist_found)
            {
                LoggedUserEmail = Email_textBox.Text;
                PharamcistOptions PO = new PharamcistOptions();
                PO.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid data!");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Start home = new Start();
            home.Show();
            this.Hide();
        }
    }
}
