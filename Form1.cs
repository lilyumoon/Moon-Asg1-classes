using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Asg1_classes
{
    public partial class Form1 : Form
    {

        Student currentStudent;
        int viewIndex = 0;

        public Form1()
        {
            /*
             * Adds some filler students into StudentList in order to 
             *   provide the form with something to display.
             */
            Student student1 = new Student("lmoon");
            student1.FirstName = "Lily";
            student1.LastName = "Moon";
            student1.NumberOfCredits = 17;

            Student student2 = new Student("gwash", "George", "Washington", 8);
            Student student3 = new Student("aeins", "Albert", "Einstein", 12);
            Student student4 = new Student("mclar", "Mamie", "Clark", 18);
            Student student5 = new Student("tswif", "Taylor", "Swift", 11);

            InitializeComponent();

            // Initializes currentStudent to first student in student list
            //   and calls UpdateFormDisplay so form populates on startup
            currentStudent = Student.StudentList[0];
            UpdateFormDisplay();
        }

        /// <summary>
        /// Updates form UI display based on currently selected student.
        /// </summary>
        private void UpdateFormDisplay()
        {
            textID.Text = currentStudent.Id.ToString();
            textStudentID.Text = currentStudent.StudentID;
            textFirstName.Text = currentStudent.FirstName;
            textLastName.Text = currentStudent.LastName;
            textEmail.Text = currentStudent.Email;
            textNumberOfCredits.Text = currentStudent.NumberOfCredits.ToString();
            checkBoxIsFullTime.Checked = currentStudent.IsFullTime;
        }

        /// <summary>
        /// Handler for 'Previous' button Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // decrement viewIndex and reset if out of bounds
            viewIndex--;
            if (viewIndex == -1) viewIndex = Student.StudentList.Count - 1;

            currentStudent = (Student)Student.StudentList[viewIndex];

            UpdateFormDisplay();
        }

        /// <summary>
        /// Handler for 'Next' button Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // increment viewIndex and reset if out of bounds
            viewIndex++;
            if (viewIndex == Student.StudentList.Count) viewIndex = 0;

            currentStudent = (Student)Student.StudentList[viewIndex];

            UpdateFormDisplay();
        }



        // TODO: Accidentally created these in the Design tab. Uncertain how to properly remove without going deeper.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
