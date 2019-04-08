using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    interface INoteBookСompound<in T>
    {
        void FormatConversion(T obj);
    }

    interface INoteBookAccessories<out T>
    {
        T UpgradeCPU();
        T UpgradeRAM();
    }
}
