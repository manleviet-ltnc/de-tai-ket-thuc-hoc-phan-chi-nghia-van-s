using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoodCalculator
{
    public partial class FoodCalculator : Form
    {
        public FoodCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FoodCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnFoodCalories_Click(object sender, EventArgs e)
        {
            var kindOfFood = new KindOfFood();
            this.Hide();
            kindOfFood.ShowDialog();
            this.Show();
        }

        private void btnBurnedCalories_Click(object sender, EventArgs e)
        {
            BurnedCalories burned = new BurnedCalories();
            this.Hide();
            burned.ShowDialog();
            this.Show();
        }

        private void btnPWS_Click(object sender, EventArgs e)
        {
            PersonalWeightStatistic statistic = new PersonalWeightStatistic();
            this.Hide();
            statistic.ShowDialog();
            this.Show();
        }
    }
}
