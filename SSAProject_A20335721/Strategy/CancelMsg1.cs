using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class CancelMsg1 : CancelMsg
    {
        public override void showCancelMsg()
        {
            Console.WriteLine("The transaction was cancelled!!");
        }
    }
}
