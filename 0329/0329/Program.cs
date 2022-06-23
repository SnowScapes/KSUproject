using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                n[i] = int.Parse(args[i]);
            }
            SumAvg(n);
        }
        static void SumAvg(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            int avg = sum / n.Length;
            Console.WriteLine("합 : {0}\n평균 : {1}", sum, avg);
        }
    }
}
