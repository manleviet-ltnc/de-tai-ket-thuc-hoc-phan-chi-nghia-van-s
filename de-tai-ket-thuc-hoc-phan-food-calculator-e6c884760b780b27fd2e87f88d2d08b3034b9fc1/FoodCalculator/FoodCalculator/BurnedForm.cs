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
    public partial class BurnedForm : Form
    {
        BUS_DailyCalories busCalories = new BUS_DailyCalories();

        private DTO_Daily todaySet;
        public DTO_Daily TodaySet
        {
            get { return todaySet; }
            set { todaySet = value; }
        }

        private float caloriesOfActivity { get; set; }
        public BurnedForm(DTO_Daily TodaySet)
        {
            InitializeComponent();
            LoadActivities();
            this.TodaySet = TodaySet;
            btnSave.Enabled = false;
        }

        public void LoadActivities()
        {
            for (int i = 0; i < busCalories.getActivities().Count(); i++)
            {
                Button btnCategory;
                Activity activity = busCalories.getActivities()[i];
                btnCategory = new Button() { Text = activity.Name, AutoSize = true, Height = 30 };
                fplActivities.Controls.Add(btnCategory);
                btnCategory.Click += (sender, EventArgs) => { BtnCategory_Click(sender, EventArgs, activity.CaloriesValue); };
            }
        }

        private void BtnCategory_Click(object sender, EventArgs e, float caloriesOfActivity)
        {
            (sender as Button).BackColor = Color.Aqua;
            this.caloriesOfActivity = caloriesOfActivity;
        }

        private void btnShowCalories_Click(object sender, EventArgs e)
        {
            double hour = ((Convert.ToInt32(nmMinute.Value) / 60.0) + (Convert.ToInt32(nmSecond.Value) / 360.0));
            string result = String.Format("{0:0.00}", hour * caloriesOfActivity);
            lblBurnedCalories.Text = result;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TodaySet.BurnedCaloriesValue = lblBurnedCalories.Text;
            this.Visible = false;
        }
    }
}
