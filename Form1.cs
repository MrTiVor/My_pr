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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void ценыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prices prices = new Prices();
            prices.Show();
        }
        
        private void внестиДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_input DT = new Data_input();
            DT.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void стоимостьАрендыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculation_results cr = new Calculation_results();
            cr.Show();
        }
    }
}
