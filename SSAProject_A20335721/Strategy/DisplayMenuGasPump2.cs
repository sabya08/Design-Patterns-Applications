using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class DisplayMenuGasPump2 : DisplayMenu
    {
        public override void showMenu()
        {
            Console.WriteLine("Select type of gas\n\t7.Super\n\t8.Regular\n\t5.Cancel");
        }
    }
}
