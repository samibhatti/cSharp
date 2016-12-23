using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Employee
    {
        private string name;
        //public int Salary;

        public string Name
        {
            get { return name; }

            set { if (!string.IsNullOrWhiteSpace(value)) name = value; }
        }

        /*       public void SetName(string name)
               {
                   if (string.IsNullOrWhiteSpace(name)) return;
                   this.name = name;
               }*/

        /* public bool SetName(string name)
         {
             if (string.IsNullOrWhiteSpace(name)) return false;
             this.name = name;
             return true;
         }*/

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { if (value >= 0) salary = value; }
        }

        /*  private DateTime startDate;
          public DateTime StartDate
          {
              get { return startDate; }
              set { startDate = value; }
          }*/


        public DateTime StartDate { get; set; }

        public Employee(string name)
        {
            Name = name;
            Salary = 0;
            StartDate = DateTime.Today;
        }

        /* public Employee(string name): this(name, 0)
         {

         }*/

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
            StartDate = DateTime.Today;
        }

        /*public int DaysEmployed()
        {
           get {

                DateTime today = DateTime.Today;
                DateTime employed = StartDate;

                TimeSpan employedTime = today - employed;

                int numberOfDays = (int)
                    employedTime.TotalDays;
                return numberOfDays;
            }

            set 
            {
                StartDate = DateTime.Today.AddDays(-Value);
            }

        }*/

        public int DaysEmployed
        {
            get { return (int)(DateTime.Today - StartDate).TotalDays; }
            set { StartDate = DateTime.Today.AddDays(-value); }
        }
     }
 }
