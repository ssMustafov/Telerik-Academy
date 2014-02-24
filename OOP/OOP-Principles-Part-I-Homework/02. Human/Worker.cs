using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    public class Worker: Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative number.");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set 
            {
                if (value > 0 && value < 15)
                {
                    this.workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentException("The work hours must be between 1 and 14 including.");
                }
            }
        }

        public string FirstName
        {
            get { return base.FirstName; }
        }

        public string LastName
        {
            get { return base.LastName; }
        }

        public double MoneyPerHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5);
        }
    }
}
