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
    public partial class Settings : Form
    {
        string connStr = "Data Source = ORCL;User Id = hr;Password=hr;";
        OracleConnection conn;

        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientHome Home = new PatientHome();
            Home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from Patient where Email = :email";
            cmd.Parameters.Add("email", Login.LoggedUserEmail);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("User Deleted");
                Login.LoggedUserEmail = "";
                Start Home = new Start();
                Home.Show();
                this.Hide();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connStr);
            conn.Open();
            PaymentComboBox.Items.Add("Cash");
            PaymentComboBox.Items.Add("Credit Card");
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            OracleCommand temp = new OracleCommand();
            temp.Connection = conn;
            temp.CommandText = "Select * from PATIENT where Email =:E";
            temp.Parameters.Add("E", Login.LoggedUserEmail);
            temp.CommandType = CommandType.Text;
            OracleDataReader Dr = temp.ExecuteReader();
            if (Dr.Read())
            {
                EmailtextBox2.Text = Dr[0].ToString();
                NametextBox1.Text = Dr[1].ToString();
                AddresstextBox3.Text = Dr[2].ToString();
                PasswordtextBox4.Text = Dr[3].ToString();
                PaymentComboBox.Text = Dr[4].ToString();
            }

            cmd.CommandText = "update Patient set Email =: email, Name =: name, Address =: address, Password =: password, Payment_Type =: payment where Email =: current_email";
            cmd.Parameters.Add("email", EmailtextBox2.Text);
            cmd.Parameters.Add("name", NametextBox1.Text);
            cmd.Parameters.Add("address", AddresstextBox3.Text);
            cmd.Parameters.Add("password", PasswordtextBox4.Text);
            cmd.Parameters.Add("payment", PaymentComboBox.SelectedItem.ToString());
            cmd.Parameters.Add("current_email", Login.LoggedUserEmail);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Your info has been modified.");
                Login.LoggedUserEmail = EmailtextBox2.Text;
            }
        }
    }
}
