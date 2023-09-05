using System.Text;
using DeltaBicycles.Business;

namespace DeltaBicycles.Data
{
    public static class DeltaSequentialData
    {
        public const string COLUMN_SEPARATOR = ",";

        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\login.txt";
        }

        public static List<Users> Load()
        {
            var listOfUsers = new List<Users>();
            string filePath = GetFilePath();

            if (!File.Exists(filePath))
            {
                return listOfUsers;
            }

            string data = File.ReadAllText(filePath);

            string[] lines = data.Split(Environment.NewLine);

            foreach (string line in lines)
            {
                string[] lineFields = line.Split(COLUMN_SEPARATOR);
                string username = lineFields[0];
                string password = lineFields[1];
                listOfUsers.Add(new Users(username, password));
            }
            return listOfUsers;
        }

        public static void Save(List<Users> listOfUsers)
        {
            string filePath = GetFilePath();

            var sb = new StringBuilder();
            foreach (Users user in listOfUsers)
            {
                if (sb.Length > 0)
                    sb.AppendLine();

                sb.Append(user.Username);
                sb.Append(COLUMN_SEPARATOR);
                sb.Append(user.Password);
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
