using System;

namespace calculator_classes
{
    internal class ArrayMath
    {
        public double Sum(double[] array)
        {
            double s = 0;
            foreach (var x in array) s += x;
            return s;
        }
        public int FindIndex(double[] arr, double target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }


        public double Max(double[] array)
        {
            double max = array[0];
            foreach (var x in array) if (x > max) max = x;
            return max;
        }

        public double Min(double[] array)
        {
            double min = array[0];
            foreach (var x in array) if (x < min) min = x;
            return min;
        }
        public double[] SortAsc(double[] array)
        {
            int s = array.Length;
            for (int i = 0; i < s - 1; i++)
            {
                for (int j = 0; j < s - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        

        }
    }
}