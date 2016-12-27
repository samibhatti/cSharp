using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook() // default constructor
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public bool ThrowAwayLowest { get; set;} // property

        public override GradeStatistics ComputeStatistics() // virtual added to enable polymorphism
        {
            Console.WriteLine("GradeBook::ComputeStatistics");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
               /* if(grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade;
                }*/
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        /* public string Name // moved to GradeTracker
         {
             get
             {
                 return _name.ToUpper(); //this is being read 
                 //return _name;
             }
             set
             {
                 if (String.IsNullOrEmpty(value))
                 {
                     throw new ArgumentException("Name cannot be null or empty");
                 }

                 if (_name != value)
                 {
                         NameChangedEventArgs args = new NameChangedEventArgs();
                         args.ExistingName = _name;
                         args.NewName = value;


                     NameChanged(this, args);
                         //NameChanged(_name, value);
                  }

                     _name = value;

                  //else
                 //{
                   //  _name = "";
                 //}

             }
         }

         public event NameChangedDelegate NameChanged; //public field
         private string _name; */

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        protected List<float> grades;
      //List<float> grades = new List<float>();
    }
}
