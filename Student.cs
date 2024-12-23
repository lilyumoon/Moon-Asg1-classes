using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Asg1_classes
{
    internal class Student
    {

        /// <summary>Starts at 1000 to facilitate imitation of Northwood Tech email address scheme</summary>
        private static int idCount = 1000;
        private int id;
        private string studentID;
        private string firstName;
        private string lastName;
        private int numberOfCredits;
        public bool IsFullTime { get => isFullTime(); }
        public string Email { get => getEmail(); }

        public static List<Student> StudentList = new List<Student>();


        public static int IdCount { get => idCount; set => idCount = value; }
        public int Id { get => id; set => id = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int NumberOfCredits { get => numberOfCredits; set => numberOfCredits = value; }

        /// <summary>
        /// Constructs a Student object.
        /// </summary>
        /// <param name="studentID">ID of student. Current format is first letter of first name 
        ///   and first four letters of last name.</param>
        public Student(string studentID)
        {
            IdCount++;
            Id = IdCount;
            StudentID = studentID;

            StudentList.Add(this);
        }

        /// <summary>
        /// Constructs a student object.
        /// </summary>
        /// <param name="studentID">ID of student. Current format is first letter of first name 
        ///   and first four letters of last name. Has a default value of empty string.</param>
        /// <param name="firstName">First name of student.</param>
        /// <param name="lastName">Last name of student.</param>
        /// <param name="numberOfCredits">Number of credits student is currently enrolled in.</param>
        public Student(string studentID, string firstName, string lastName, int numberOfCredits) 
        {
            IdCount++;
            Id = IdCount;
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            NumberOfCredits = numberOfCredits;

            StudentList.Add(this);
        }

        /// <summary>
        /// Helper function to determine whether or not student is considered full time.
        /// </summary>
        /// <returns>True if student is taking 12 or more credits.</returns>
        private bool isFullTime()
        {
            return NumberOfCredits >= 12;
        }

        /// <summary>
        /// Helper function to provide student's email address.
        /// </summary>
        /// <returns>Student's email address.</returns>
        private string getEmail()
        {
            string part1 = FirstName.Substring(0, 1).ToLower();
            string part2 = LastName.Length >= 4 ? LastName.Substring(0, 4).ToLower() : LastName.Substring(0, LastName.Length - 1).ToLower();
            return part1 + part2 + Id + "@northwoodtech.edu";
        }

    }
}
