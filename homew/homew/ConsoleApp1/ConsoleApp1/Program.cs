using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int nameList(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {

                if (names[i].Length > 5)
                {
                    count++;
                }
            }
            return count;
        }
    } // Verilmis adlar siyahisinda (string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram
    

}


