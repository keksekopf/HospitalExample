using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExample
{
    internal class Surgeon : Staff
    {
        private string speciality;
        public List<Patient> assignedPatients; // The patients that the surgeon is assigned to
        private Database database;

        public Surgeon(string name, int age, string mobile, string email, string password, int staffID, string speciality, Database database) : base(name, age, mobile, email, password, staffID)
        {
            // Just set the speciality because base constructor handles other fields
            this.speciality = speciality;
        }

        public override void DisplayDetails()
        {
            // Display whatever details the surgeon needs to display
        }

        public void PerformSurgery(Patient patient)
        {
            // Perform surgery on the patient
            // Set patient's completedSurgery to true
        }
    }
}
