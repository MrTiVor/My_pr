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
        Prices prices = new Prices();
        private void ценыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prices.Show();
        }
        Data_input DT = new Data_input();
        private void внестиДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT.Show();
        }
    }
}
