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
    public partial class PersonalWeightStatistic : Form
    {
        public PersonalWeightStatistic()
        {
            InitializeComponent();
        }

        private static string GetDayToString(string d)
        {
            string result = "";
            switch (d)
            {
                case "1": result = "1st"; break;
                case "2": result = "2nd"; break;
                case "3": result = "3rd"; break;
                default: result = d + "th"; break;
            }
            return result;
        }

        private static string GetMonthToString(string m)
        {
            string result = "";
            switch (m)
            {
                case "1": result = "Jan"; break;
                case "2": result = "Feb"; break;
                case "3": result = "Mar"; break;
                case "4": result = "Apr"; break;
                case "5": result = "May"; break;
                case "6": result = "Jun"; break;
                case "7": result = "Jul"; break;
                case "8": result = "Aug"; break;
                case "9": result = "Sep"; break;
                case "10": result = "Oct"; break;
                case "11": result = "Nov"; break;
                case "12": result = "Dec"; break;
            }
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("Now is {0}:{1}:{2} {3}-{4}-{5}",
                                        DateTime.Now.Hour,
                                        DateTime.Now.Minute,
                                        DateTime.Now.Second,
                                        GetMonthToString((DateTime.Now.Month).ToString()),
                                        GetDayToString((DateTime.Now.Day).ToString()),
                                        DateTime.Now.Year);
        }
    }
}
