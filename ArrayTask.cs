using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void MinimumValueAmongOdd(int[] array, int counter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] < counter || counter == 0)
                        counter = array[i];
                }
            }
            Console.WriteLine(counter);
        }

        static void MultipleOf4And7IncreaseIn9(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 4 == 0 || array[i] % 7 == 0)
                {
                    Console.Write(array[i] * 9 + " ");
                }
            }
            Console.WriteLine();
        }

        static void MultipleOf4(int[] array, int counter)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 4 == 0 && counter < 3)
                {
                    Console.Write(array[i] + " ");
                    counter++;
                }
            }
            Console.WriteLine();
        }

        static void MultipleOf7(int[] array, int counter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 7 == 0 && counter < 4)
                {
                    Console.Write(array[i] + " ");
                    counter++;
                }
            }
            Console.WriteLine();
        }

        static void MultipleOf8(int[] array, int counter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 8 == 0)
                    counter++;
            }
        }

        static void Main()
        {
            int[] array = { 12, 14, 80, 21, -6, 8, 32, 7, 63, 4, 70 };
            int counter = 0;

            MultipleOf8(array, counter);
            MultipleOf7(array, counter);
            MultipleOf4(array, counter);
            MultipleOf4And7IncreaseIn9(array);
            MinimumValueAmongOdd(array, counter);

            Console.ReadKey();
        }
    }
}
