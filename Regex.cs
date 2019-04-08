using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            string pattern = @"^0$|^[1-9]\d?\d?\d?$";

            while (true)
            {
                Console.Write("Введите число от 0 до 9999: ");
                string number = Console.ReadLine();

                if (Regex.IsMatch(number, pattern))
                {
                    Console.WriteLine("Вы ввели правильное число!");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное число/не число!");
                }
            }
        }
    }
}
