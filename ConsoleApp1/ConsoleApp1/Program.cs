using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunde, minute;
            Console.WriteLine("Upišite sekunde:");
            sekunde = Convert.ToInt32(Console.ReadLine());
            minute = sekunde / 60;
            sekunde = sekunde - minute * 60;
            Console.WriteLine(minute+"minute i "+sekunde+"sekundi!");


            Console.ReadKey();
        }
    }
}
