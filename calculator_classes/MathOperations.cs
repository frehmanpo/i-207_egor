using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace calculator_classes
{
    internal class MathOperations
    {
         
        public double sum(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;

        }
        public double Divide(double a, double b)
        {
            if (b != 0)  return a / b;
            Console.WriteLine("Ошибка  на ноль делить нельзя");
                return 0;
        }
        public BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public int Mod(int a, int b)
        {
            return a % b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public double Percent(double num, double prc)
        {
            return (num * prc) / 100;
        }
        public double DPercent(double first, double last)
        {
            
          return last / first * 100;
            
            
        }
    }

    
}
