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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("FoodInformation.txt");
            if (reader == null) return;
            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                lbxFoodInformation.Items.Add(input);
            }
            reader.Close();
        }
    }
}
