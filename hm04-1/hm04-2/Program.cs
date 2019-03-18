using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите W A S D");
            String choise = Console.ReadLine();
                           
            switch (choise)
            {
                case "w":
                    Console.WriteLine("Вверх");
                    break;
                case "a":
                    Console.WriteLine("Назад");
                    break;
                case "s":
                    Console.WriteLine("Вниз");
                    break;
                case "d":
                    Console.WriteLine("Вниз");
                    break;

            }
            Console.ReadKey();


        }
    }
}
