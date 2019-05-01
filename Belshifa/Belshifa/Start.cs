using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belshifa
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void LoginFormButton_Click(object sender, EventArgs e)
        {
            Login Gui = new Login();
            Gui.Show();
            this.Hide();
        }

        private void SignupFormButton_Click(object sender, EventArgs e)
        {
            if (Pharmacist.Checked)
            {
                RegisterPharmacist Gui = new RegisterPharmacist();
                Gui.Show();
                this.Hide();
            }
            else if (Patient.Checked)
            {
                Register Gui = new Register();
                Gui.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please choose which user type!");
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
