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
    public partial class StatisticForm : Form
    {
        private DTO_DailyData dailySets;
        public DTO_DailyData DailySets
        {
            get { return dailySets; }
            set { dailySets = value; }
        }

        public StatisticForm(DateTime Date, DTO_DailyData DailySets)
        {
            InitializeComponent();
            this.DailySets = DailySets;
            dtpkDay.Value = Date;
        }

        private void ClearStatisticForm()
        {
            lblFoodCalories.Text = "0";
            lblBurnedCalories.Text = "0";
            lblTotal.Text = "0";
        }
        private void ShowSetByDate(DateTime date)
        {
            float total = 0;
            
            ClearStatisticForm();
            DTO_Daily todaySet = GetJobByDay(date);
           
            if (todaySet != null)
            {
                total = float.Parse(todaySet.CrossirantsValue) - float.Parse(todaySet.BurnedCaloriesValue);
                lblFoodCalories.Text = todaySet.CrossirantsValue;
                lblBurnedCalories.Text = todaySet.BurnedCaloriesValue;
                lblTotal.Text = total.ToString();
            }
            else
            {
                return;
            }

        }
        private void dtpkDay_ValueChanged(object sender, EventArgs e)
        {
            ShowSetByDate((sender as DateTimePicker).Value);
        }

        DTO_Daily GetJobByDay(DateTime date)
        {
            return DailySets.DTO_Daily.Find(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDay.Value = dtpkDay.Value.AddDays(1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dtpkDay.Value = dtpkDay.Value.AddDays(-1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpkDay.Value = DateTime.Now;
        }
    }
}
