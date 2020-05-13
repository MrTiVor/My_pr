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
           Data.a  = "Автобус";
        }


        private void minibus_lease_CheckedChanged(object sender, EventArgs e)//радиокнопка микроавтобус
        {
            Data.flag_minibus = this.minibus_lease.Checked;
            Data.b = "Микроавтобус";
        }

        private void taxi_lease_CheckedChanged(object sender, EventArgs e)//радиокнопка Такси
        {
            Data.flag_taxi = this.taxi_lease.Checked;
            Data.c = "Такси";
        }
        Prices ipb = new Prices();


        private void button_OK_data_input_Click(object sender, EventArgs e)//кнопка ОК
        {
            if (this.input_time.Text != "")
            {
                try
                {
                        {

                            Data.arenda_time = Int32.Parse(this.input_time.Text);
                        if(Data.arenda_time>0)
                        {
                            this.Close();
                            Calculation_results cr = new Calculation_results();
                            cr.Show();
                        }
                            else
                        {
                            MessageBox.Show("Введено отрицательное количество часов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        }
                }
                catch
                {
                    MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            else
            {
                MessageBox.Show("Не введена длительность аренды автомобиля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        

    }

        private void Data_input_Load(object sender, EventArgs e)
        {

        }
    }
}
