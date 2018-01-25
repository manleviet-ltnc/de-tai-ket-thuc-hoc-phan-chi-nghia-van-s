
using BUS_CaloriesCalculator;
using DTO_CaloriesCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CaloriesCalculatorVer2
{
    public partial class foodCalculator : Form
    {
        BUS_DailyCalories busCalories = new BUS_DailyCalories();
        // Đường dẫn tới file
        private string filePath = "data.xml";
        // Tất cả các Set
        private DTO_DailyData dailySets;
        public DTO_DailyData DailySets
        {
            get { return dailySets; }
            set { dailySets = value; }
        }
        // Set hôm nay
        private DTO_Daily todaySet;
        public DTO_Daily TodaySet
        {
            get { return todaySet; }
            set { todaySet = value; }
        }
        // Null Set
        public DTO_Daily NullSet = new DTO_Daily();
        // Constructor
        public foodCalculator()
        {
            InitializeComponent();
            DailySets = busCalories.DeserializeFromXML(filePath) as DTO_DailyData;
            TodaySet = new DTO_Daily();
        }

        /// <summary>
        /// Click to Foods Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaloriesProducts_Click(object sender, EventArgs e)
        {
            FoodsForm foodsForm = new FoodsForm(TodaySet);
            this.Hide();
            foodsForm.ShowDialog(this);
            this.Show();
        }

        private void btnBurnedCalories_Click(object sender, EventArgs e)
        {
            BurnedForm burnedForm = new BurnedForm(TodaySet);
            this.Hide();
            burnedForm.ShowDialog(this);
            this.Show();
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            UpdateFile();
            StatisticForm statisticForm = new StatisticForm(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), DailySets);
            this.Hide();
            statisticForm.ShowDialog(this);
            this.Show();
        }

        private void UpdateFile()
        {
            DateTime todayDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DTO_Daily existSet = DailySets.DTO_Daily.Find(p => p.Date == todayDate);
            if (existSet != null)
            {
                DailySets.DTO_Daily.Remove(existSet);
            }
            DailySets.DTO_Daily.Add(TodaySet);
            busCalories.SerializeToXML(DailySets, filePath);
        }

        private void foodCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateFile();
        }

        private void foodCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
