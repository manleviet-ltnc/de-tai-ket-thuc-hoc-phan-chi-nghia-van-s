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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            List<string> Food = new List<string>();
            using (StreamReader reader = new StreamReader("c:\\calo.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] delimiters = new char[] { '1', ' ', ' ', ' ', ' ' };
                    string[] parts = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string c in parts)
                    {
                        txtElement.Text = parts[0];
                        txtEnergy.Text = parts[1];
                        txtProtein.Text = parts[2];

                    }
                }

                reader.Close();
            }
        }
        
    }
}
