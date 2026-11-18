using System;

namespace calculator_classes
{
    internal class GUIConsolApp
    {
      public void Start()
       {
                MathOperations math = new MathOperations();
                ArrayMath arrayMath = new ArrayMath();
                bool cont = true;

                while (cont)
                {
                    Console.WriteLine("\nВыберите задачу: \n" +
                        "0 - счет процентов\n" +
                        "1 - умножение\n" +
                        "2 - деление\n" +
                        "3 - вычитание\n" +
                        "4 - сложение\n" +
                        "5 - сумма массива\n" +
                        "6 - поиск в массиве\n" +
                        "7 - максимум массива\n" +
                        "8 - минимум массива\n" +
                        "9 - факториал\n" +
                        "10 - деление на остаток и деление на целое\n" +
                        "11 - обратное процентам\n" +
                        "12 - сортировка массива\n" +
                        "Выберите номер задачи: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 0)
                    {
                        Console.Write("Введите число: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите процент: ");
                        double prc = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Результат: " + math.Percent(num, prc) + "\n");
                    }
                    else if (choice == 1)
                    {
                        Console.Write("Введите первое число: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Результат: " + math.Multiply(a, b) + "\n");
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Введите первое число: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (b != 0) Console.Write("Результат: " + math.Divide(a, b) + "\n");
                        else Console.Write("На ноль делить нельзя!\n");
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Введите первое число: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Результат: " + math.Subtract(a, b) + "\n");
                    }
                    else if (choice == 4)
                    {
                        Console.Write("Введите первое число: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Результат: " + math.sum(a, b) + "\n");
                    }
                    else if (choice == 5 || choice == 6 || choice == 7 || choice == 8 || choice == 12)
                    {
                        Console.Write("Введите размер массива: ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        double[] arr = new double[size];
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write("arr[" + i + "] = ");
                            arr[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        if (choice == 5) Console.Write("Сумма: " + arrayMath.Sum(arr) + "\n");
                        if (choice == 6)
                        {
                            Console.Write("Какой элемент ищем? ");
                            double target = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Индекс: " + arrayMath.FindIndex(arr, target) + "\n");
                        }
                        if (choice == 7) Console.Write("Максимум: " + arrayMath.Max(arr) + "\n");
                        if (choice == 8) Console.Write("Минимум: " + arrayMath.Min(arr) + "\n");
                        if (choice == 12)
                        {
                            double[] sorted = arrayMath.SortAsc(arr);
                            Console.Write("Отсортированный массив: ");
                            foreach (var x in sorted) Console.Write(x + " ");
                            Console.Write("\n");
                        }
                    }
                    else if (choice == 9)
                    {
                        Console.Write("Введите число: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Факториал: " + math.Factorial(n) + "\n");
                    }
                    else if (choice == 10)
                    {
                        Console.Write("Введите делимое: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите делитель: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        if (b != 0)
                            Console.Write("Целое: " + math.Div(a, b) + ", Остаток: " + math.Mod(a, b) + "\n");
                        else
                            Console.Write("На ноль делить нельзя!\n");
                    }
                    else if (choice == 11)
                    {
                        Console.Write("Введите первое число: ");
                        double first = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double second = Convert.ToDouble(Console.ReadLine());
                        if (second != 0)
                            Console.Write("Первое число составляет " + math.DPercent(first, second) + "% от второго\n");
                        else
                            Console.Write("На ноль делить нельзя!\n");
                    }
                    else
                    {
                        Console.Write("Неверный пункт меню!\n");
                    }

                    Console.Write("\nХотите продолжать? (y/n): ");
                    string answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y")
                        cont = true;
                    else
                        break;
                }

                Console.Write("Программа завершена.\n");
                Console.ReadLine();
            }
        }
    }











