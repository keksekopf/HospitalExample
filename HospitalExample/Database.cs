using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExample
{
    internal class Database
    {
        private List<User> users; // Contains all users - this works because all users inherit from the User class, so they technically are all 'Users'

        public Database()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        // This method will return a user object if the email matches the email of a user in the database
        public User GetUser(string email)
        {
            // Retrieve the user from the database based on their email, if it exists
            return null;
        }
    }
}
