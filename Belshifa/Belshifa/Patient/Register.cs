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

        private void RegisterButton_Click(object sender, EventArgs e)
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
                temp.CommandText = "Select :Email from Patient";
                temp.Parameters.Add("Email", EmailTextBox.Text);
                temp.CommandType = CommandType.Text;
                OracleDataReader Dr = temp.ExecuteReader();
                if(Dr.Read())
                {
                    MessageBox.Show("Email ALready Exists");
                    return;
                }

                cmd.CommandText = "insert into Patient values (:Email, :name, :Address, :Password, :Payment)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("Email", EmailTextBox.Text);
                cmd.Parameters.Add("name", NameTextBox.Text);
                cmd.Parameters.Add("Address", AddressTextbox.Text);
                cmd.Parameters.Add("Password", PasswordTextbox.Text);
                cmd.Parameters.Add("Payment", PaymentComboBox.SelectedItem.ToString());

                int value = cmd.ExecuteNonQuery();
                if (value == -1)
                {
                    MessageBox.Show("Something went wrong!");
                }
                else
                {
                    MessageBox.Show("Registered successfully!");
                    PatientHome Home = new PatientHome();
                    Home.Show();
                    this.Hide();
                }
            }
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
    }
}
