using System;
using System.Collections.Generic;
using System.IO;
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
            IGradeTracker book = CreateGradeBook();
            //GradeTracker book = CreateGradeBook();
            //GradeBook book = CreateGradeBook();
            //ThrowAwayGradeBook book = new ThrowAwayGradeBook();

            // book.NameChanged += OnNameChanged;
            // book.NameChanged += OnNameChanged2;
            // book.NameChanged -= OnNameChanged2;
            // book.Name = "Scott Grade Book";
            // book.Name = "Grade Book";
            //book.Name = null;

            /* try
               {
                   Console.WriteLine("Enter a name");
                   book.Name = Console.ReadLine();
               }
               catch (ArgumentException ex)
               {
                   Console.WriteLine(ex.Message);
               }
               catch (NullReferenceException) // ex variable is optional
               {
                   Console.WriteLine("something went wrong!");
               }*/

            //GetBookName(book);
            AddingGrades(book);
            SaveGrades(book);
            WriteResults(book);

            /*  StreamWriter outputFile = File.CreateText("grades.txt");
                book.WriteGrades(outputFile);
                outputFile.Close();*/
            //book.WriteGrades(Console.Out);
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
            //synth.Speak("Hello! This is the grade book program" + stats.AverageGrade + stats.HighestGrade + stats.LowestGrade);

            //GradeBook book2 = new GradeBook();
            //GradeBook book2 = book; //reference pointer to gradebook object in memory
            //book2.AddGrade(75);

        }

        private static IGradeTracker CreateGradeBook()
        {
            /* GradeBook g1 = new GradeBook();
             GradeBook g2 = g1;

             g2= new GradeBook();
             g1.Name = "Scott grade book";
             Console.WriteLine(g2.Name);

             SpeechSynthesizer synth = new SpeechSynthesizer();
             //synth.Speak("Hello! This is the grade book program");
             */

            //GradeBook book = new GradeBook();
            return new ThrowAwayGradeBook();
        }

         private static void WriteResults(IGradeTracker book)
        //private static void WriteResults(GradeBook book)
        //private static void WriteResults(ThrowAwayGradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }
            // Console.WriteLine(book.Name);

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade); // (int) is type conversion from float to int
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            //WriteResult("Grade", stats.LetterGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
      //private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
                //outputFile.Close();
            }
        }

        private static void AddingGrades(IGradeTracker book)
      //private static void AddingGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
      //private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException) // ex variable is optional
            {
                Console.WriteLine("something went wrong!");
            }
        }

        /*    static void OnNameChanged(object sender, NameChangedEventArgs args)
            {
                Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
            }*/

        /*static void OnNameChanged(string existingName, string newName)
          {
              Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
          }

          static void OnNameChanged2(string existingName, string newName)
          {
              Console.WriteLine("***");
          }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }*/

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }

        /*static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }*/
    }
}
