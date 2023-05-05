using System.Text.Json;

namespace Final_Practice
{
    public class Program
    {
        public static void Main()
        {
            bool active = true;

            while (active)
            {
                Console.Clear();
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1: Login");
                Console.WriteLine("2: Register");
                Console.WriteLine("3: Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        User user = Login();
                        if (user is not null)
                        {
                            Game game = new Game(user);
                        }
                        break;
                    case "2":
                        Register();
                        break;
                    case "3":
                        active = false;
                        break;

                }
            }
        }

        

        public static User Login()
        { 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please type in ur email");
                String email = Console.ReadLine().ToLower();

                Console.WriteLine("Please type in ur password");
                String password = Console.ReadLine();

                List<User> users = Authentication.GetUser();
                Console.WriteLine(users.Count);

                
                foreach (User user in users)
                {
                    user.PrintUser();
                    if (user.Email == email && user.Password == password)
                    {
                        Console.Write("You are logged in, press to continue");
                        Console.ReadKey();
                        return user;
                    }
                }

                Console.WriteLine("Incorrect data, press 1 to try again, or 2 to ext");
                String input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        break;
                    case "2":
                        return null;
                }
            }
            

        }

        public static void Register()
        {
            Console.Clear();
            Console.Write("Username: ");
            String username = Console.ReadLine();

            Console.Write("Email: ");
            String email = Console.ReadLine().ToLower();

            bool passwordsMatch = false;

            String firstPassword = "";
            String secondPassword = "";

            while (!passwordsMatch)
            {

                Console.Write("Password: ");
                firstPassword = Console.ReadLine();

                Console.Write("Please confirm Password: ");
                secondPassword = Console.ReadLine();

                if (firstPassword == secondPassword)
                {
                    passwordsMatch = true;

                }
                else
                {
                    Console.WriteLine("Passwords dont match please try again");
                }
            }

            User user = new User(email, username, firstPassword);
            Authentication.SaveUser(user);
            Console.WriteLine("User created, press to continue");
            Console.ReadKey();
        }

        

    }

}
