using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0419
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5개의 정수를 입력하세요");
            int sum = 0, n = 0;
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("i > ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("정수가 아닙니다. 다시 입력해 주세요");
                    i--;
                    continue;
                }
                sum += n;
            }
            Console.WriteLine("합은 "+sum);
        }
    }
}
