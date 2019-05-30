using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            INoteBookСompound<NewFormat> format = new NoteBook<Format>();
            NewComponent newComponent = new NewComponent();
            INoteBookAccessories<Component> accessories = new NoteBook<NewComponent>();

            Console.WriteLine(format.ToString());
            Console.WriteLine(accessories.ToString());

            Console.ReadKey();
        }
    }
}
