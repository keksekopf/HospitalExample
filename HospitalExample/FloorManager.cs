using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalExample
{
    internal class FloorManager : Staff
    {
        private int floorNumber; // This allows the floormanager to know which floor they are managing
        private Database database; // This allows the floor manager to access the database

        public FloorManager(string name, int age, string mobile, string email, string password, int staffID, int floorNumber, Database database) : base(name, age, mobile, email, password, staffID)
        {
            // Just set the speciality because base constructor handles other fields
            this.floorNumber = floorNumber;
            this.database = database; // allows the floor manager to access the same instance of the database passed into it
        }

        public override void DisplayDetails()
        {
            // Display whatever details the floor manager needs to display
        }

        public void AssignPatientToRoom(Patient patient, int roomNumber)
        {
            // Assign the patient to the room
            patient.roomNumber = roomNumber;
            // Also check whether that room is available, some logic like 
            // if (roomNumber is available) { assign the patient to the room }
        }

        public void ScheduleSurgery(Patient patient, DateTime surgeryTime, Surgeon surgeon)
        {
            // Schedule the surgery for the patient
            patient.scheduledSurgery = surgeryTime;
            patient.assignedSurgeon = surgeon;
            surgeon.assignedPatients.Add(patient); // Add the patient to the surgeon's list of assigned patients
        }

        public void CheckOutPatient(Patient patient)
        {
            // Check the patient out
            patient.checkedIn = false;
        }

        public void UnassignRoom(Patient patient)
        {
            // Unassign the patient from the room
            patient.roomNumber = 0;
        }
    }
}
