using DeltaBicycles.Business;
using System.Xml.Serialization;

namespace DeltaBicycles.Data
{
    public static class DeltaXmlData
    {
        private static string GetFieldPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\Student.xml";
        }

        public static List<Bike> Load()
        {
            var listOfBikes = new List<Bike>();
            string filePath = GetFieldPath();
            if (!File.Exists(filePath))
                return listOfBikes;

            string data = File.ReadAllText(filePath);

            if (data.Trim().Length == 0)
            {
                return listOfBikes;
            }

            string[] lines = data.Split(Environment.NewLine);

            using (var sr = new StringReader(data))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                return (List<Bike>)serializer.Deserialize(sr)!;
            }
        }

        public static void Save(List<Bike> listOfBike)
        {
            string filePath = GetFieldPath();
            using (var filestream = new StreamWriter(filePath))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Bike>));
                xmlSerializer.Serialize(filestream, listOfBike);
            }
        }
    }
}
