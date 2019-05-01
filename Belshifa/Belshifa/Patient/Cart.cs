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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
            DataSet ds = new DataSet();
            OracleDataAdapter adapter1 = new OracleDataAdapter("SELECT DISTINCT CATEGORY FROM MEDICATION",ordb);
            adapter1.Fill(ds, "CATEGORY");
            OracleDataAdapter adapter2 = new OracleDataAdapter("SELECT NAME,USAGE,PRICE,INDICATION,SIDE_EFFECTS,PRECAUTIONS,DRUG_DRUG_INTERACTION,DRUG_FOOD_INTERACTION, CATEGORY FROM MEDICATION", ordb);
            adapter2.Fill(ds, "Medication");
            DataRelation r = new DataRelation("CM", ds.Tables[0].Columns["CATEGORY"], ds.Tables[1].Columns["CATEGORY"]);
            ds.Relations.Add(r);
            BindingSource master = new BindingSource(ds, "CATEGORY");
            BindingSource child = new BindingSource(master, "CM");
            dataGridView1.DataSource = master;
            dataGridView2.DataSource = child;

 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
