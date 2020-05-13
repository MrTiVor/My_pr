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
    public partial class Calculation_results : Form
    {
        public Calculation_results()
        {
            InitializeComponent();
        }

        private void Calculation_results_Load(object sender, EventArgs e)
        {
            if(Data.flag_bus)
            {

                this.arenda_choise_result.Text += (" "+Data.a.ToString());
                int arenda_calculated = Data.arenda_time * Data.price_bus;
                this.arenda_price_result.Text += (" " + arenda_calculated.ToString()+" р");
            }
            else if(Data.flag_minibus)
            {
                this.arenda_choise_result.Text += (" " + Data.b.ToString());
                int arenda_calculated = Data.arenda_time * Data.price_minibus;
                this.arenda_price_result.Text += (" " + arenda_calculated.ToString() + " р");
            }
            else if (Data.flag_taxi)
            {
                this.arenda_choise_result.Text += (" " + Data.c.ToString());
                int arenda_calculated = Data.arenda_time * Data.price_taxi;
                this.arenda_price_result.Text += (" " + arenda_calculated.ToString() + " р");
            }
            this.arenda_time_result.Text += (" "+Data.arenda_time.ToString() + "ч");
          
        }

        private void arenda_choise_result_Click(object sender, EventArgs e)
        {

        }

        private void arenda_time_result_Click(object sender, EventArgs e)
        {

        }

        private void arenda_price_result_Click(object sender, EventArgs e)
        {

        }
    }
}
