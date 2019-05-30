using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public abstract class Component { }
    public abstract class Format { }
    public class NewComponent : Component { }
    public class NewFormat : Format { }

    public class NoteBook<T> : INoteBookСompound<T>, INoteBookAccessories<T>
    {
        public T newCPU;
        public T newRAM;
        public T newFormat;

        public void FormatConversion(T format)
        {
            this.newFormat = format;
        }

        public T UpgradeCPU()
        {
            return newCPU;
        }

        public T UpgradeRAM()
        {
            return newRAM;
        }
    }
}
