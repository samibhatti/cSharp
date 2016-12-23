using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övening2_TeoretiskLokalBio
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doItAgain = true;
            do
            {
                Console.Clear();
                //int input = 0;
                Console.WriteLine("Välkommen till Teoretisk Lokal Bio!");
                Console.WriteLine();
                Console.WriteLine("1. Tryck 1 för att kolla priset");
                Console.WriteLine("2. Tryck 2 för upprepa ord tio gånger");
                Console.WriteLine("3. Tryck 3 för ord count");
                Console.WriteLine("0. Tryck 0 för att Avsluta programmet");
                //Console.ReadKey();
                string input = Console.ReadLine();
                //Console.Clear();
                switch (input)
                {
                    case "0":
                        doItAgain = false;
                        break;
                    case "1":
                        Console.WriteLine("Änge Ålder:");
                        int age = int.Parse(Console.ReadLine());
                        visapriset(age);
                        break;
                    case "2":
                        Console.WriteLine("Änge Ord för upprepa tio gånger:");
                        string ord = Console.ReadLine();
                        upprepaOrd(ord);
                        break;
                    case "3":
                        Console.WriteLine("Ord Count:");
                        string ord1 = Console.ReadLine();
                        ordCount(ord1);
                        break;
                    default:
                        Console.WriteLine("Felaktig input try again");
                        break;
                }
                Console.ReadKey();
            } while (doItAgain);
            
        }

        private static void visapriset(int age)
        {

            if (age < 20)
                Console.WriteLine("Entered age: " + age + " Biljet priset för Ungdomar är 80kr");
            else if (age > 64)
                Console.WriteLine("Entered age: " + age + " Biljet priset för Pensionär är 90kr");
            else
                Console.WriteLine("Entered age: " + age + " Biljet priset för Standardpris är 120kr");
        }

        private static void upprepaOrd(string ord)
        {
            Console.WriteLine("Entered string: " + ord);
        }

        private static void ordCount(string ord1)
        {
            Console.WriteLine("Entered string: " + ord1);
        }
    }   
}
