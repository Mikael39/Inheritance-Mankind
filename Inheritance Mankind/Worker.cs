using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mankind
{
    public class Worker : Human
    {
        protected int weekSalary;
        protected int workHoursPerDay;
        protected double hourlyWage;


        public int WorkHoursPerDay 
        { 
            get { return workHoursPerDay; } 
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");

                else                 
                workHoursPerDay = value; 
            } 
        }
        public int WeekSalary
        {
            get { return weekSalary; }

            set
            {
                 if (value < 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");

                else
                   
                weekSalary = value;
            }
        }

        public double HourlyWage { get { return hourlyWage; } set { hourlyWage = value; } }

        public Worker(int weekSalary, int workHoursPerDay, string firstName, string lastName, double hourlyWage) : base(firstName, lastName)
        {
            WorkHoursPerDay = workHoursPerDay;
            WeekSalary = weekSalary;
            HourlyWage = hourlyWage;
        }

        

        public override string ToString()
        {
            var resultBuilder2 = new StringBuilder();
            resultBuilder2.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary}")
            .AppendLine($"Hours per day: {this.WorkHoursPerDay}")
            .AppendLine($"Salary per hour: {this.HourlyWage}");

            string result = resultBuilder2.ToString().TrimEnd();
            return result;
        }

    }
}
