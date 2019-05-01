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
    public partial class Register : Form
    {
        string connStr = "Data Source = ORCL;User Id = hr;Password=hr;";
        OracleConnection conn;
        public Register()
        {
            InitializeComponent();
        }

        private void BackButton(object sender, EventArgs e)
        {
            Start Home = new Start();
            Home.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connStr);
            conn.Open();
            PaymentComboBox.Items.Add("Cash");
            PaymentComboBox.Items.Add("Credit Card");
        }

        private void RegisterButton_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (NameTextBox.Text == "" || EmailTextBox.Text == "" || AddressTextbox.Text == "" || PasswordTextbox.Text == "" || PaymentComboBox.Text == "")
            {
                MessageBox.Show("Please Enter All values");
            }
            else
            {
                OracleCommand temp = new OracleCommand();
                temp.Connection = conn;
                temp.CommandText = "Select EMAIL from Patient where EMAIL =:email";
                temp.Parameters.Add("email", EmailTextBox.Text);
                temp.CommandType = CommandType.Text;
                OracleDataReader Dr = temp.ExecuteReader();
                if (Dr.Read())
                {
                    if (Dr[0].ToString() == EmailTextBox.Text)
                    {
                        MessageBox.Show(Dr[0].ToString());
                        MessageBox.Show("Email ALready Exists");
                        return;
                    }
                    Dr.Close();
                }

                cmd.CommandText = "insert into Patient values (:E, :n, :A, :P, :P)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("E", EmailTextBox.Text);
                cmd.Parameters.Add("n", NameTextBox.Text);
                cmd.Parameters.Add("A", AddressTextbox.Text);
                cmd.Parameters.Add("P", PasswordTextbox.Text);
                cmd.Parameters.Add("P", PaymentComboBox.SelectedItem.ToString());

                int value = cmd.ExecuteNonQuery();
                if (value == -1)
                {
                    MessageBox.Show("Something went wrong!");
                }
                else
                {
                    MessageBox.Show("Registered successfully!");
                    Login.LoggedUserEmail = EmailTextBox.Text;
                    PatientHome Home = new PatientHome();
                    Home.Show();
                    this.Hide();
                }
            }
        }
    }
}
