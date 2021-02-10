using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson02.Models
{
    public class Calculator
    {
        private int result = 0;

        public Calculator() { 
        }

        public int Add(int num1, int num2 = 0)
        {
            result = num1 + num2;
            return result;
        }

        public int Add(int num1, int num2, int num3)
        {
            result = num1 + num2 + num3;
            return result;
        }


        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
