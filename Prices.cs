using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class Prices : Form
    {
        public Prices()
        {
            InitializeComponent();
        }
        Data pr_t = new Data();
        
        private void Prices_Load(object sender, EventArgs e)
        {
            this.input_price_bus.Text = (" "+Data.price_bus.ToString()+" р");
            this.input_price_minibus.Text = (" " + Data.price_minibus.ToString() + " р");
            this.input_price_taxi.Text = (" " + Data.price_taxi.ToString() + " р");
        }

        private void Prices_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void input_price_bus_Click(object sender, EventArgs e)
        {

        }

        //public String bus_price
        //{
        //    get
        //    {
        //        return input_price_bus.Text;
        //    }
        //}
    }
}
