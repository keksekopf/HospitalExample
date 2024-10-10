using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExample
{
    // The user class is abstract because we don't want to create a user object, but we want to create objects of the classes that inherit from User
    // Users are simply meant to represent the common properties of all users
    internal abstract class User 
    {
        // Properties common to all users, so we define them here, as all classes that inherit from User will have these properties
        private string name;
        private int age;
        private string mobile;
        private string email;
        private string password;

        // This creates a user object with the given parameters, and you'll use this constructor to 'register' a user
        public User (string name, int age, string mobile, string email, string password)
        {
            this.name = name;
            this.age = age;
            this.mobile = mobile;
            this.email = email;
            this.password = password;
        }

        // Allows other classes to change the user's private field 'password'
        public void ChangePassword(string newPassword)
        {
            this.password = newPassword;
        }

        // Display's the user's details - we want it here because this method will be common to all users
        public abstract void DisplayDetails();


        // These methods can be put elsewhere, but adding them into the user class will work for this assessment
        public bool Login(string email, string password)
        {
            // used to login the user, returns a bool to indicate whether the login was successful
            // check if the email and password match the details stored in the database
            // if (Database.Users.email == email & the same for the password) return true;
            return true;
        }

        public void Logout()
        {
            // used to logout the user
        }
    }
}
