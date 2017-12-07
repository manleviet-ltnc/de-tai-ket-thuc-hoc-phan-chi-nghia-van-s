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

namespace FoodCalculator
{
    public partial class Calories : Form
    {
        DataTable dt = new DataTable();
        string[] lines = null;
        Button btn;

        public Calories()
        {
            InitializeComponent();
        }

        // Load dishes to Calories From when clicking a kind of food
        public void LoadMenu(String kindName)
        {
            // default Header of table
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Fat", typeof(float));
            dt.Columns.Add("Carb", typeof(float));
            dt.Columns.Add("Pro", typeof(float));
            dt.Columns.Add("Calories", typeof(float));
            dt.Columns.Add("Other", typeof(float));

           
            // Check kind of food to load txt file
            if (kindName == "Fast Food")
            {
                lines = File.ReadAllLines(@"C:\Users\LittleboyQti\Desktop\test.txt");
                
            }
            if (kindName == "Fish and SeaFood")
            {
                lines = File.ReadAllLines(@"C:\Users\LittleboyQti\Desktop\fish_seafood.txt");

            }
            if ( lines != null)
            {
                foreach (var line in lines)
                {
                    var firstValue = line.Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[0];
                    Random rand = new Random();
                    btn = new Button() { Text = firstValue, Location = new Point(rand.Next(0, 100), rand.Next(0, 100)) };
                    btn.AutoSize = true;
                    btn.Height = 30;
                    //btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
                    flpMenu.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
            this.Controls.Add(flpMenu);

           
        }

        // Choose a dish
        private void Btn_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.AliceBlue;
            dt.Clear();
            showInfoIntoTable(sender, e);
        }

        // Fill data to table when clicking a dish
        public void showInfoIntoTable(object sender, EventArgs e)
        {
            List<string> item = null;
            Object firstValue;
            String choosenValue = (sender as Button).Text;
            int index = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                firstValue = lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[0];
                if (String.Equals(choosenValue, firstValue))
                {
                    dt.Rows.Add(
                        lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[0], 
                        lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[1],
                        lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[2],
                        lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[3],
                        lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[4],
                        lines[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries)[5]);
                    dtgvInfo.DataSource = dt;
                    break;
                }
            }
            
        }

        // Caculate calories by ounces
        private void btnCaculate_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                float result = (float)numbUpDown.Value * dt.Rows[0].Field<float>("Calories");
                lblResultCross.Text = result.ToString();                
            }
        }
    }
}
