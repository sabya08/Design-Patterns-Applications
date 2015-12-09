using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class DisplayMenuGasPump3 : DisplayMenu
    {
        public override void showMenu()
        {
            Console.WriteLine("Select type of gas\n\t5.Premium\n\t6.Regular\n\t4.Cancel");
        }
    }
}
