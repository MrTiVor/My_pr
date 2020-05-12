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
    public partial class Data_input : Form
    {
        public Data_input()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//радиокнопка Автобус
        {
            Data.flag_bus = this.bus_lease.Checked;
        }

        private void minibus_lease_CheckedChanged(object sender, EventArgs e)//радиокнопка микроавтобус
        {
            Data.flag_minibus = this.minibus_lease.Checked;
        }

        private void taxi_lease_CheckedChanged(object sender, EventArgs e)//радиокнопка Такси
        {
            Data.flag_taxi = this.taxi_lease.Checked;
        }
        Prices ipb = new Prices();
        

        private void button_OK_data_input_Click(object sender, EventArgs e)
        {
            if (Data.flag_bus)
            {
               

            }
        }
    }
}
