using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class Urunler : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);

        DataSet ds;
        DataTable tbl;
        SqlCommand cmd;
        string sql;
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }
    }
}
