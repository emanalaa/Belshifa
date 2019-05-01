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
    public partial class Update_Delete : Form
    {
        public Update_Delete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PharamcistOptions Home = new PharamcistOptions();
            Home.Show();
            this.Hide();
        }
    }
}
