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
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start Home = new Start();
            Home.Show();
            this.Hide();
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            Order Home = new Order();
            Home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings Home = new Settings();
            Home.Show();
            this.Hide();
        }
    }
}
