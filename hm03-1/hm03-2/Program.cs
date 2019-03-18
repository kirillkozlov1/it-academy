using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string num1 = Console.ReadLine();
            int a = Convert.ToInt32(num1);
            Console.WriteLine("Введите второее число");
            string num2 = Console.ReadLine();
            int b = Convert.ToInt32(num2);
            Console.WriteLine("Введите сумму двух чисел");
            string res = Console.ReadLine();
            int c = Convert.ToInt32(res);
            if (c == a + b)
                Console.WriteLine("Правильно");
            else
                Console.WriteLine("Не правильно");
            Console.ReadKey();
        }
    }
}
