using System;

namespace homew
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static int FindNumberCount(int[] numbers, int n)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)

            {
                if (numbers[i] == n)

                {
                    count++;
                }

            }

            return count;

            // verilmis qiymetlerin ortalamasin hesablayan metod 
        }

        static int CalcAvgPoint(int[] points)
        {

            int sum = 0;

            for (int i = 0; i < points.Length; i++)
            {
                sum += points[i];

            }

            int avg = sum / points.Length;

            return avg;

        }

        // Verilmis adlar siyahisinda axtarilan adin olub olmadigini tapan bi metod.

        static bool HasName(string[] names, string name)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return true;
            }

            return false;




        }
    }
}
