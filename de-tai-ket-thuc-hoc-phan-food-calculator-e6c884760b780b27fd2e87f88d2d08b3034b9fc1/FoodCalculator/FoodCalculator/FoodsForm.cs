using BUS_CaloriesCalculator;
using DTO_CaloriesCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesCalculatorVer2
{
    public partial class FoodsForm : Form
    {
        BUS_DailyCalories busCalories = new BUS_DailyCalories();
        List<List<string>> dishes;

        // Set hôm nay
        private DTO_Daily todaySet = new DTO_Daily();
        public DTO_Daily TodaySet { get => todaySet; set => todaySet = value; }
        public FoodsForm(DTO_Daily TodaySet)
        {
            InitializeComponent();
            this.TodaySet = TodaySet;
            btnSave.Enabled = false;
        }

        private void FoodsForm_Load(object sender, EventArgs e)
        {
            LoadDish();
        }

        /// <summary>
        /// Load Các Món Trong File Text Lên Form
        /// </summary>
        private void LoadDish()
        {
            Button btnDish;
            dishes = busCalories.getDishes();
            foreach (var dish in dishes)
            {
                btnDish = new Button() { Text = dish[0], AutoSize = true, Height = 30 };
                fplFoods.Controls.Add(btnDish);
                btnDish.Click += (sender, EventArgs) => { BtnDish_Click(sender, EventArgs, dish); };
            };
        }

        private void BtnDish_Click(object sender, EventArgs eventArgs, List<string> dish)
        {
            lblName.Text = (sender as Button).Text;
            lblFat.Text = dish[1];
            lblCarb.Text = dish[2];
            lblPro.Text = dish[3];
            lblCalories.Text = dish[4];
            lblOther.Text = dish[5];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TodaySet.Name = lblName.Text;
            TodaySet.CaloriesValue = lblCalories.Text;
            TodaySet.ProValue = lblPro.Text;
            TodaySet.CarbValue = lblCarb.Text;
            TodaySet.FatValue = lblFat.Text;
            TodaySet.OtherValue = lblOther.Text;
            TodaySet.Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            TodaySet.CrossirantsValue = lblCrossirants.Text;
            this.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float result = 0;
            result = (float)numUpDown.Value * Int32.Parse(lblCalories.Text);
            lblCrossirants.Text = result.ToString();
            btnSave.Enabled = true;
        }
    }
}

