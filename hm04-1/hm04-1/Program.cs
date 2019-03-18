using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char c = 'Z'; c >= 'A'; c--)
                Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
