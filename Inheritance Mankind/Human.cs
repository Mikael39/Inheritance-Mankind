using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mankind
{
    public class Human
    {

        protected string firstName;
        protected string lastName;

        public string FirstName
        {
            get { return firstName; }

            set
              
            {
                if (Char.IsLower(value, 0))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                else if (value.Length < 4)
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                else
                firstName = value;
            }

        }
        public string LastName
        {

            get { return lastName; }

            set
            {

                if (Char.IsLower(value, 0))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                else if (value.Length < 3)
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                else
                    lastName = value;

            }
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }


      


    }
}
