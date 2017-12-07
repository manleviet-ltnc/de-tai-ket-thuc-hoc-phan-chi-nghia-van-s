using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\LittleboyQti\Desktop\Trinh Hong\de-tai-ket-thuc-hoc-phan-food-calculator\Test\bin\Debug\New-Bread-and-Cereals.txt");
            foreach (String line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
