using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void musterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.MdiParent = this;
            customer.Show();
        
        }

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.MdiParent = this;
            urunler.Show();
        }
    }
}
