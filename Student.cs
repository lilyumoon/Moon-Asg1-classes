using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Asg1_classes
{
    internal class Student
    {

        private static int idCount = 0;
        private int id;
        private String studentID;
        private String firstName;
        private String lastName;
        private String email;
        private int numberOfCredits;
        public bool IsFullTime { get => isFullTime(); }


        public static int IdCount { get => idCount; set => idCount = value; }
        public int Id { get => id; set => id = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int NumberOfCredits { get => numberOfCredits; set => numberOfCredits = value; }


        public Student(String studentID)
        {
            IdCount++;
            Id = IdCount;
            this.StudentID = studentID;
        }

        public Student(String studentID, String firstName, String lastName, String email, int numberOfCredits) 
        {
            IdCount++;
            Id = IdCount;
            this.StudentID = studentID;
        }

        private bool isFullTime()
        {
            return NumberOfCredits >= 12;
        }

    }
}
