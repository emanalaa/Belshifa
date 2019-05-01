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
    public partial class RegisterPharmacist : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection con;
        public RegisterPharmacist()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start Home = new Start();
            Home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            List<string> usernames = new List<string>();
            List<string> pharmacynos = new List<string>();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please Enter all fields");
            }
            else
            {
                bool usernamecheck = true;
                bool pharmacynocheck = true;
                cmd.Connection = con;
                cmd.CommandText = "select USERNAME from PHARMACIST";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usernames.Add(dr[0].ToString());
                }
                for (int i = 0; i < usernames.Count; i++)
                {
                    if (usernames[i] == textBox2.Text)
                    {
                        MessageBox.Show("This Username is already taken, choose another one");
                        usernamecheck = false;
                    }
                }
                cmd.CommandText = "select PHARMACY_NO from PHARMACIST";
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pharmacynos.Add(dr[0].ToString());
                }
                for (int i = 0; i < pharmacynos.Count; i++)
                {
                    if (pharmacynos[i] == textBox4.Text)
                    {
                        MessageBox.Show("This Pharmacy Number already exists,enter another one");
                        pharmacynocheck = false;
                    }
                }
                if (usernamecheck && pharmacynocheck)
                {
                    cmd.CommandText = "insertintopharmacist";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("phname", textBox1.Text);
                    cmd.Parameters.Add("username", textBox2.Text);
                    cmd.Parameters.Add("phpassword", textBox3.Text);
                    cmd.Parameters.Add("phno", int.Parse(textBox4.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" A record has been added");
                }
            }
        }
        private void RegisterPharmacist_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();


        }

        private void RegisterPharmacist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
