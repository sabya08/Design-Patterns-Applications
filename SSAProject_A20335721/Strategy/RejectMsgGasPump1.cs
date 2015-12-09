using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class RejectMsgGasPump1 : RejectMsg
    {
        public override void printRejectMsg()
        {
            Console.WriteLine("Sorry, your card is rejected!!");
        }
    }
}
