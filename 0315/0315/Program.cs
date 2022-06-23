using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("윤년");
            else
                Console.WriteLine("평년");
        }
    }
}
