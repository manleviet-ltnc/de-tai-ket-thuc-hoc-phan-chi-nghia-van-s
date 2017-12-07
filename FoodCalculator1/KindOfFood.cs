using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCalculator
{
    public partial class KindOfFood : Form
    {
        public KindOfFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calories c = new Calories();
            c.Show();
        }

        private void KindOfFood_Load(object sender, EventArgs e)
        {

        }
    }
}
