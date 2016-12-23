﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook() // default constructor
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
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
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name.ToUpper(); //this is being read 
                //return _name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    _name = value;
                } else
                {
                    _name = "";
                }
            
            }
        }

        private string _name;
        private List<float> grades;
      //List<float> grades = new List<float>();
    }
}