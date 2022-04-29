using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    internal class Calculator
    {
        public double DIvision(double firstNumber, double secondNumber)
        {   
            if(secondNumber == 0.0)
            {
                throw new DivideByZeroException($"Attenzione, divisione di {firstNumber} per zero.");
            }
            return firstNumber / secondNumber;
        }
    }
}
