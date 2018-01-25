using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_CaloriesCalculator
{
    [Serializable()]
    public class DTO_Daily
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string FatValue { get; set; }
        public string CarbValue { get; set; }
        public string ProValue { get; set; }
        public string CaloriesValue { get; set; }
        public string OtherValue { get; set; }
        public string CrossirantsValue { get; set; }
        public string BurnedCaloriesValue { get; set; }
        public DTO_Daily()
        {
            this.Date = DateTime.Now;
            this.Name = null;
            this.FatValue = null;
            this.CarbValue = null;
            this.ProValue = null;
            this.CaloriesValue = null;
            this.OtherValue = null;
            this.CrossirantsValue = null;
            this.BurnedCaloriesValue = null;
        }
    }
}
