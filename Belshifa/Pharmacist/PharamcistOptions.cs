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
    public partial class PharamcistOptions : Form
    {
        public PharamcistOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Delete GUI = new Update_Delete();
            GUI.Show();
            this.Hide();
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }
    }
}
