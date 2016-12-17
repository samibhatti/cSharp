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

            //Huvudmenu
            bool doItAgain = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Teoretisk Lokal Bio!");
                Console.WriteLine();
                Console.WriteLine("1. Tryck 1 för att kolla priset");
                Console.WriteLine("2. Tryck 2 för upprepa ord tio gånger");
                Console.WriteLine("3. Tryck 3 för ord count");
                Console.WriteLine("0. Tryck 0 för att Avsluta programmet");
                Console.WriteLine();
                Console.WriteLine("Välja val:");
                string input = Console.ReadLine();
                //Switch-sats för att välja funktioner
                switch (input)
                {
                    case "0":
                        doItAgain = false;
                        break;
                    case "1":
                        Console.WriteLine("Änge Ålder:");
                        int age = 0;
                        bool parsed = int.TryParse(Console.ReadLine(), out age);
                        if (parsed)
                            visaPriset(age);
                        else
                            Console.WriteLine("Felaktig ålder");
                        break;
                    case "2":
                        Console.WriteLine("Änge Ord för upprepa tio gånger:");
                        string ord = Console.ReadLine();
                        upprepaOrd(ord);
                        break;
                    case "3":
                        ordCount();                       
                        break;
                    default:
                        Console.WriteLine("Felaktig input försök igen");
                        break;
                }
                Console.ReadKey();
            } while (doItAgain);
            
        }

        //Funktioner som kolla biljet priset till ungdomar, pensioner och standardpris.
        private static void visaPriset(int age)
        {

            if (age < 20)
                Console.WriteLine("Biljet priset för Ungdomar är 80kr");
            else if (age > 64)
                Console.WriteLine("Biljet priset för Pensionär är 90kr");
            else
                Console.WriteLine("Biljet priset för Standardpris är 120kr");
        }

        //Funktioner som upprepa ord tio gånger
        private static void upprepaOrd(string ord)
        {
            Console.WriteLine("Upprepar Ord:");

            for (int i=0; i<10; i++)
            {
                Console.Write(ord);
            }
        }

        //Funktioner som räkna ord och skriva ut tredja ordet.
        private static void ordCount()
        {
            
            string input = string.Empty;
            bool flag = true;
            do
            {
                Console.WriteLine("Änge minst tre ord med ett mellanslag:");
                input = Console.ReadLine();
                string [] splitOrd = input.Split(' ');
                if(splitOrd.Count() > 2)
                {
                    flag = false;
                    Console.WriteLine("Det tredja ordet är: " + splitOrd[2]);
                } 
            }
            while (flag);

            
        }
    }   
}
