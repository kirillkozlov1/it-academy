using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm03_1
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
            int c = a + b;
            Console.WriteLine("Результат:" + c);
            Console.ReadKey();
        }
    }
}
