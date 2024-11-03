using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        private string studentID, firstName, lastName;

        public StudentInfo(string studentID, string firstName, string lastName)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
        }

        public string StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
    }
}
