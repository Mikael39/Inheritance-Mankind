using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mankind
{
    public class Student : Human
    {
        protected int facultyNumber;

        public int FacultyNumber { get { return facultyNumber; } set { facultyNumber = value; } }

        public Student(int facultyNumber, string firstName, string lastName) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
