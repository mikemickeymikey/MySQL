using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBDDMySQL
{
    public partial class Form1 : Form
    {
        private classicmodelsDataSet ds;

        public Form1()
        {
            InitializeComponent();
            ds = new classicmodelsDataSet();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillByPLineMore100(ds.products, "Ships");
        }

        
    }
}
