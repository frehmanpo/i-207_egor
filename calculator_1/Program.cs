using System;

namespace project
{

    class Program
    {
        static void Main()

        {
            while (true)
            {


                Console.WriteLine("Введите первое число:");
                float num1;
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                float num2;
                num2 = float.Parse(Console.ReadLine());



                float resultaddition;
                resultaddition = num1 + num2; //сложение

                float resultsubtraction;
                resultsubtraction = num1 - num2;  //вычитание 

                float resultmul;
                resultmul = num2 * num1; // умножение

                float resultdiv;
                resultdiv = num2 / num1; //деление 




                Console.WriteLine("Переменная: " + resultaddition, resultsubtraction, resultmul, resultdiv);
            }
        }
    }
}
