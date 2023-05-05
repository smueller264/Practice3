using System;
using System.Text.Json;

namespace Final_Practice
{
    public class Authentication
    {
        public Authentication()
        {
        }



        public static List<User> GetUser()
        {
            string userPath = @"users/users.json";

            string jsonUser = File.ReadAllText(userPath);
            Console.WriteLine($"Users: {jsonUser}");
            List<User> userList;
            try
            {
                userList = JsonSerializer.Deserialize<List<User>>(jsonUser);
            }
            catch (Exception e)
            {
                userList = new List<User>();
            }

            return userList;
        }

        public static void SaveUser(User user)
        {
            string userPath = @"users/users.json";



            string oldUsers = File.ReadAllText(userPath);
            List<User> userList;
            try
            {
                userList = JsonSerializer.Deserialize<List<User>>(oldUsers);
            }
            catch (Exception e)
            {
                userList = new List<User>();
            }


            userList.Add(user);

            string json = JsonSerializer.Serialize(userList);
            Console.WriteLine("Writing json");
            Console.WriteLine(json);

            File.WriteAllText(userPath, json);
            Console.WriteLine("Save User");
        }
    }
}

