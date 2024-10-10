using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExample
{
    // Patient inherits from user
    internal class Patient : User
    {
        public int roomNumber;
        public DateTime scheduledSurgery; // The surgery that the patient is scheduled for. You can use this to display the patient's surgery time and assigned surgeon
        public Surgeon assignedSurgeon; // The surgeon that is assigned to the patient
        public bool completedSurgery; // Determines whether the patient has completed their surgery, important for the floor manager checking patients out
        public bool checkedIn; // Determines whether the user is checked in or not

        public Patient(string name, int age, string mobile, string email, string password) : base(name, age, mobile, email, password)
        {
            // No need to define anything here, as the base constructor will handle it
            // This allows us to not duplicate code
        }

        public override void DisplayDetails()
        {
            // Display whatever details the patient needs to display
        }

        public void CheckIn()
        {
            // Check the patient in
            checkedIn = true;
        }

        public void CheckOut()
        {
            // Check the patient out
            checkedIn = false;
        }

        public void ViewRoomNumber()
        {
            // Display the patient's room number
        }

        public void ViewScheduledSurgery()
        {
            // Display the patient's scheduled surgery
        }

        public void ViewAssignedSurgeon()
        {
            // Display the patient's assigned surgeon
        }
    }
}
