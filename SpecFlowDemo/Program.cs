using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Sum(10,20);

            Console.WriteLine(r.ToString());

            Console.ReadLine();
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
    public class Calculator
    {
        public int rusult = 0;

    }
}
