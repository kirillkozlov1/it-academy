using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на русском языке");
            string word = Console.ReadLine();
            int schet = 0;
            char poisk = 'а';

            foreach (Char letter in word)
                if (letter == poisk) schet++;
            {
                Console.WriteLine("Количество букв а:" + schet);
            }
            Console.ReadKey();
        }
    }
}
