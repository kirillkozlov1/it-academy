using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm03_4
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
            Console.WriteLine("Введите + или -");
            string oper = Console.ReadLine();
            char z = Convert.ToChar(oper);
            Console.WriteLine("Введите сумму/разность двух чисел");
            string res = Console.ReadLine();
            int c = Convert.ToInt32(res);

            int y = 0;
            if (z == '+') y = a + b;
            if (z == '-') y = a - b;

            if (c == y)
                Console.WriteLine("Верно");
            if (c != y)
                Console.WriteLine("Не Верно");
            if (c < y)
                Console.WriteLine("Нужно больше");
            if (c > y)
                Console.WriteLine("Нужно меньше");

            Console.ReadKey();
        }
    }
}
