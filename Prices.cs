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

        private void Prices_Load(object sender, EventArgs e)
        {

        }

        private void Prices_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void input_price_bus_Click(object sender, EventArgs e)
        {

        }
        public String bus_price
        {
            get
            {
                return input_price_bus.Text;
            }
        }
    }
}
