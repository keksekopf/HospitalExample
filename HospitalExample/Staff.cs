using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExample
{
    internal abstract class Staff : User
    {
        private int staffID;

        public Staff(string name, int age, string mobile, string email, string password, int staffID) : base(name, age, mobile, email, password)
        {
            // Just set the stafffId because base constructor handles other fields
            staffID = staffID;
        }

        // Don't need to implement display details cuz staff is abstract
    }
}
