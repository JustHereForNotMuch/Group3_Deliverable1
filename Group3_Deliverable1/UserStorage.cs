using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace Group3_Deliverable1
{
    public static class UserStorage
    {
        private static readonly string FilePath = "users.xml";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
            {
                return new List<User>();
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    return (List<User>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                return new List<User>();
            }
        }

        public static bool SaveUser(User newUser)
        {
            try
            {
                List<User> users = LoadUsers();

                // Prevent duplicate usernames (case-insensitive)
                if (users.Exists(u => u.Username.Equals(newUser.Username, StringComparison.OrdinalIgnoreCase)))
                {
                    return false;
                }

                users.Add(newUser);

                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                using (StreamWriter writer = new StreamWriter(FilePath))                           ///USed XML to serialize since json gave me errors
                                                                                                    ///Could only be used if external package was downloaded
                {
                    serializer.Serialize(writer, users);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}


