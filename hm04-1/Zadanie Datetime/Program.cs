using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DateTime.Now.Hour;
            var b = DateTime.Now.Minute;
            var c = DateTime.Now.Second;
            Console.WriteLine($"Текущее время: {a} часов {b} минут {c} секунд");
            if (a >= 9 && a < 12)
                Console.WriteLine("good morning");
            if (a >= 12 && a < 15)
                Console.WriteLine("good day");
            if (a >= 15 && a < 22)
                Console.WriteLine("good evening");
            if (a >= 22 && a < 24)
                Console.WriteLine("good hight");
            if (a >= 0 && a < 9)
                Console.WriteLine("good hight");

            Console.ReadKey();

        }
    }
}
