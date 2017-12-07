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
    public partial class Calories : Form
    {
        public Calories()
        {
          //  Load();
            InitializeComponent();
        }
        
        private void lblBiscuts_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("C:\\Biscuits.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] delimiters = new char[] { '|' };
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < parts.Length; i++)
                    {
                        listThongtin.Text = parts[i];

                    }

                }

            }
        }
    }
}