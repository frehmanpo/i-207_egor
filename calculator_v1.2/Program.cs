using System;

namespace PEPE
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введиет второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Выбери действия +,-,*,/");
                string sign = Console.ReadLine();
                double result = 0;
                if (sign == "*")
                {
                    result = num1 * num2;
                }
                else if (sign == "/")
                {
                    result = num1 / num2;
                }
                if (sign == "+")
                {
                    result = num1 + num2;
                }
                if (sign == "-")
                {
                    result = num1 - num2;
                }
                Console.WriteLine(result);
            }
        }
    }
}

