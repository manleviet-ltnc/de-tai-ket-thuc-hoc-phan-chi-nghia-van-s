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
            loadKindOfFood();
        }

        // Load the kind of food to form
        private void loadKindOfFood()
        {
            String[] kindNames = { "Bread and Cereals", "Fast Food", "Fish and SeaFood", "Vegatable" };
            for (int i = 0; i < kindNames.Length; i++)
            {
                Button btn = new Button() { };
                btn.Text = kindNames[i];
                flpKindOfFood.Controls.Add(btn);
                btn.Click += Btn_Click;
            }

        }

        // Choose a food category
        private void Btn_Click(object sender, EventArgs e)
        {
            String kindName = (sender as Button).Text;
            Calories calories = new Calories();
            calories.Show();
            calories.LoadMenu(kindName);
        }

        private void KindOfFood_Load(object sender, EventArgs e)
        {

        }

        private void btnFish_Click(object sender, EventArgs e)
        {

        }
    }
}
