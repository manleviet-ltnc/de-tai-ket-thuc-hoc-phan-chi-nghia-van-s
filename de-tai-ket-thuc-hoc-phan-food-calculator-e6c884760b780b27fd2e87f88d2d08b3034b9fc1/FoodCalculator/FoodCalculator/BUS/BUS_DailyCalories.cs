using DAL_CaloriesCalculator;
using DTO_CaloriesCalculator;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BUS_CaloriesCalculator
{
    public class BUS_DailyCalories
    {
        DAL_DailyCalories dalDailyCalories = new DAL_DailyCalories();
        public List<List<string>> getDishes()
        {
            return dalDailyCalories.getDishes();
        }
        public List<Activity> getActivities()
        {
            return dalDailyCalories.getActivities();
        }
        /// <summary>
        /// Đưa dữ liệu xuống
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        public void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DTO_DailyData));
            sr.Serialize(fs, data);
            fs.Close();
        }
        /// <summary>
        /// Lấy dữ liệu lên
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public DTO_DailyData DeserializeFromXML(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            DTO_DailyData result = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DTO_DailyData));
                result = (DTO_DailyData)serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                reader.Close();
            }
            return result;
        }
    }
}
