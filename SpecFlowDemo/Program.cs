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
            Calculator calc = new Calculator();
            int r = calc.Sum();

            Console.WriteLine(r.ToString());

            Console.ReadLine();
        }
    }
    
}
