using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArr = new int[100];
            for (int i = 1; i < 100; i++)
            {
                numArr[i] = i;
            }

            foreach(var item in numArr)
            {
                if (item % 3 == 0)
                {
                    if (item % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (item % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
