using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
           /* GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g2= new GradeBook();
            g1.Name = "Scott grade book";
            Console.WriteLine(g2.Name);
         
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! This is the grade book program");
            */
            GradeBook book = new GradeBook();
            book.Name = "Scott Grade Book";
            //book.Name = null;
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade); // (int) is type conversion from float to int
            WriteResult("Lowest", stats.LowestGrade);
          //Console.WriteLine(stats.AverageGrade);
          //Console.WriteLine(stats.HighestGrade);
          //Console.WriteLine(stats.LowestGrade);
          //synth.Speak("Hello! This is the grade book program" + stats.AverageGrade + stats.HighestGrade + stats.LowestGrade);

            //GradeBook book2 = new GradeBook();
            //GradeBook book2 = book; //reference pointer to gradebook object in memory
            //book2.AddGrade(75);
          
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        } 
    }
}
