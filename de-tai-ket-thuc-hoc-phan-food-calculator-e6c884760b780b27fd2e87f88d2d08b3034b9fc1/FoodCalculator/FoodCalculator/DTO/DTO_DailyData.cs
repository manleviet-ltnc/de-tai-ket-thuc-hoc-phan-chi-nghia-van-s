using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DTO_CaloriesCalculator
{
    [Serializable()]
    public class DTO_DailyData
    {
        private List<DTO_Daily> DTO_daily;

        [XmlArray("Sets")]
        [XmlArrayItem("DTO_Daily", typeof(DTO_Daily))]
        public List<DTO_Daily> DTO_Daily
        {
            get { return DTO_daily; }
            set { DTO_daily = value; }
        }
    }
}
