using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int directorySize = 2;
            Employee[] employees = new Employee[directorySize];

            Directory directory = new Directory(directorySize); //added Directory class

            bool doItAgain = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Välkommen till personalregistret!");
                Console.WriteLine();
                Console.WriteLine("M. Mata in uppgifter");
                Console.WriteLine("V. Visa personallistan");
                Console.WriteLine("Q. Avsluta");

                string selection = AskForString("> ").ToUpper();
                Console.Clear();
                switch (selection) //(selection.ToUpper())
                {
                    case "M":
                        Console.WriteLine("Ange dina anställdas uppgifter:");
                        AddEmployees(directory);
                        break;
                    case "V":
                        Console.WriteLine("Personalregistret innehåller följande personer:");
                        FindEmployee(directory);
                        break;
                    case "S":
                        Console.WriteLine("Search:");
                        ListEmployees(directory);
                        break;
                    case "Q":
                        doItAgain = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Tryck på any key för att visa listan");
                Console.ReadKey();
            } while (doItAgain);

        }


        private static void ListEmployees(Directory directory)
        {

            foreach(Employee employee in directory.ListAll())   //added Directory class
            {
                Console.WriteLine();
                Console.WriteLine("Namn: " + employee.Name);
                Console.WriteLine("Lön: " + employee.Salary + " kr");
                Console.WriteLine("Start: " + employee.StartDate);
                Console.WriteLine("Dagar: " + employee.DaysEmployed);
            } 
        }

        private static void FindEmployee(Directory directory)
        {
           var query = AskForString("Ange namn på personen: ");

           var result = directory.Find(query);
           
           foreach (Employee employee in directory.ListAll())   //added Directory class
            {
                Console.WriteLine();
                Console.WriteLine("Namn: " + employee.Name);
                Console.WriteLine("Lön: " + employee.Salary + " kr");
                Console.WriteLine("Start: " + employee.StartDate);
                Console.WriteLine("Dagar: " + employee.DaysEmployed);
            }
        }

        //private static void AddEmployees(int directorySize, Employee[] employees)
        //private static void AddEmployees(Employee[] employees)
        private static void AddEmployees(Directory directory)
        {
            //int directorySize = employees.Length;
            //int counter = 0;
            while (true)
            {
                Console.WriteLine();
                string name = AskForString("Ange namn: ");
                if (name == "") break;

                int salary = AskForInt("Ange lön: ");
                int days = AskForInt("Hur många dagar dagar " + name + " varit anställd ?");
                directory.Add(new Employee(name, salary) //added for directory class
                {
                    DaysEmployed = days
                });

            }
        }

        private static int AskForInt(string question)
        {
            int value;
            bool parsed;
            string error = "";
            do
            {
                string input = AskForString(question + error);
                parsed = int.TryParse(input, out value);
                error = "error";
            } while (!parsed); //(parsed == false)

            return value;
        }

        private static string AskForString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
           /* string name = Console.ReadLine();
            return name;*/
        }
    }
}

/*            int counter = -1;
             foreach (Employee employee in employees)
             {
               counter = counter + 1;
               if (employee != null) continue;

                string name = AskForString("Ange namn: ");
                if (name == "") break;

                int salary = AskForInt("Ange lön: ");
                int days = AskForInt("Hur många dagar dagar " + name + " varit anställd ?");

                employees[counter] = new Employee() {
                    Salary = salary,
                    Name = name,
                    StartDate = DateTime.Today
                };

                directory.Add(new Employee(name, salary) //added for directory class
                {
                    DaysEmployed = days
                });   
                
                employees[counter] = new Employee(name, salary)
                {
                    DaysEmployed = days
                    StartDate = DateTime.Today.AddDays(1)
                };

             }*/

/*do
{

    string name = AskForString("Ange namn: ");

    if (name == "") break;
    int salary = AskForInt("Lön: ");

    employees[counter] = new Employee(name, salary);
    counter = counter + 1;

} while (counter < directorySize);*/
// cleanup: return;
// }
// int counter = 0;
//Console.WriteLine("Ange namn: ");          
//if (name == "") goto cleanup;
// if (name == "") return;
/*{
    break;
}*/
// markera for refactor
//string question = "Lön: ";

/* employees[counter] = new Employee()
 {
     Name = name,
     Salary = salary

 };*/

// employees[counter].SetName(name); //added

//employees[counter] = temp;

/* private static int AskForInt(string question)
 {
     string salaryString = AskForString(question);
     int salary;
     int.TryParse(salaryString, out salary);
     return salary;
 }*/

/* private static int AskForInt(string question)
 {
     string input = AskForString(question);
     int salary;
     int.TryParse(input, out salary);
     return salary;
 }*/

//AddEmployees(directory);

//while (counter < 2);


/*foreach (Employee employee in employees)
{
     Employee employee1 = new Employee();
     employee1.Name = "Agneta";
     employee1.Salary = 20000;

//Console.WriteLine(employee1.GetType());
if (employee == null) break;
Console.WriteLine("Namn: " + employee.Name);
Console.WriteLine("Lön: " + employee.Salary + " kr");
} */
/*
int counter = 0;
do
{
    // int counter = 0;
    //Console.WriteLine("Ange namn: ");          
    string name = AskForString("Ange namn: ");

    if (name == "") break;

    {
        break;
    }
// markera for refactor
//string question = "Lön: ";
int salary = AskForInt("Lön: ");

employees[counter] = new Employee()
{
    Name = name,
    Salary = salary

};

//employees[counter] = temp;
counter = counter + 1; */

//private static void ListEmployees(Employee[] employees)
// foreach (Employee employee in employees)
// {
/* Employee employee1 = new Employee();
 employee1.Name = "Agneta";
 employee1.Salary = 20000;
 */
//Console.WriteLine(employee1.GetType());
/*   if (employee == null) break;
   Console.WriteLine();
   Console.WriteLine("Namn: " + employee.Name);
   Console.WriteLine("Lön: " + employee.Salary + " kr");
   Console.WriteLine("Start: " + employee.StartDate);
   Console.WriteLine("Dagar: " + employee.DaysEmployed);*/
// }
