using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_9
{
    public static class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;

            }).ContinueWith((i) =>
            {
                return i.Result * 2; //continuation of another task as soon as the first finishes
            });

            Console.WriteLine(t.Result); // Display 84

            Console.ReadKey();
        }
    }
}
