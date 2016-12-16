using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_8
{
    public static class Program
    {
        public static void Main()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100000; x++)
                {
                    Console.Write('*');
                }
            });

            t.Wait();
            //Console.ReadKey();
        }

    }
}
