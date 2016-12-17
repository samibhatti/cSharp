using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Speech.Synthesis;


namespace ConsoleApplication1_18.Threads
{
    public static class Program
    {
        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello Zainab Fatima Inaya Hello Zainab Fatima  Hello Zainab  Zainab ");
            //synth.Speak("Hello Zainab Fatima Inaya Hello Zainab Fatima  Hello Zainab  Zainab");
            Console.ReadKey();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
                
            }
            
        }
    }
}
