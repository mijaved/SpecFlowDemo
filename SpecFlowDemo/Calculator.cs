using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo
{
    public class Calculator
    {
        public int valA { get; set; }
        public int valB { get; set; }
        public int valC { get; set; }
        public int result { get; set; }

        public Calculator()
        {
            valA = valB = valC = result = 0;
        }

        public Calculator(int a, int b, int c = 0)
        {
            this.valA = a;
            this.valB = b;
            this.valC = c;
        }

        public int Sum()
        {
            result = valA + valB + valC;
            return result;
        }

        public int Deduct()
        {
            result = valA - valB;
            return result;
        }

        public int Multiply()
        {
            result = valA * valB;
            return result;
        }

    }
}
