using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankApp
{
    class User
    {
        private string firstName;
        private string lastName;
        private string username;
        private string password;

        public User()
        {
        }

        public User(string firstName, string lastName, string username, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 50 characters.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 50 characters.");
                }
                lastName = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Maximum length of username address is 50 characters.");
                }
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;

                password = value;

            }
        }
        public virtual string GetDisplayText() => firstName + " " + lastName + ", " + username;
    }
}
    

