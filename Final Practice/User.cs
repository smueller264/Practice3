using System;
namespace Final_Practice
{
	public class User
	{
		private String email;
		private String username;
		private String password;

		public String Email
		{
			get
			{
				return this.email;
			}
			set
			{
				email = value;
			}
		}
		public String Username {
            get
            {
                return this.username;
            }
            set
            {
                username = value;
            }
        }
		public String Password {
            get
            {
                return this.password;
            }
            set
            {
                password = value;
            }
        }


		public User()
		{
		}

		public User(String email, String username, String password)
		{
			this.email = email;
			this.password = password;
			this.username = username;
		}

		public void PrintUser()
		{
			Console.WriteLine(this.Email, this.Password);
		}
	}
}

