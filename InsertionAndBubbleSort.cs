using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int buf = array[i];
                int j = i;

                while (j > 0 && buf < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = buf;
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }
        }

        static void BubbleSort(int[] array)
        {
            int buf;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        buf = array[i];
                        array[i] = array[j];
                        array[j] = buf;
                    }
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] array = { 3, 4, 2, 1, 5, 6, 7 };

            BubbleSort(array);
            InsertionSort(array);

            Console.ReadKey();
        }
    }
}
