using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    { 
        static void Main()
        {
            var file = new FileInfo(@"D:\mail.txt");
            string[] mail = new string[] { "@gmail.com", "@yandex.ru", "@ukr.net" };
            Random random = new Random();
            var builder = new StringBuilder();
            int gmailCounter = 0, yandexCounter = 0, ukrCounter = 0;

            FileStream stream = file.Create();
            stream.Close();

            StreamWriter writer = file.CreateText();

            for (int i = 0; i < 2000000; i++)
            {
                writer.WriteLine(RandomMailName() + builder.Append(mail[random.Next(0, 3)]));
            }

            writer.Close();

            string RandomMailName()
            {
                builder = builder.Clear();
                var length = random.Next(2, 10);
                for (var i = 0; i < length; i++)
                    builder.Append((char)random.Next('a', 'z' + 1));
                
                return builder.ToString();
            }

            using (StreamReader read = new StreamReader(@"D:\mail.txt"))
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();

                    if (new Regex(@"@gmail.com").IsMatch(line))
                        gmailCounter++;
                    if (new Regex(@"@yandex.ru").IsMatch(line))
                        yandexCounter++;
                    if (new Regex(@"@ukr.net").IsMatch(line))
                        ukrCounter++;
                }
            Console.WriteLine("gmail.com amount: {0}\nyandex.ru amount: {1}\nurk.net amount: {2}", gmailCounter, yandexCounter, ukrCounter);
            Console.ReadKey();
        }
    }
}
