using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class StopMsgImpl : StopMsg
    {
        public override void printStopMsg()
        {
            Console.WriteLine("Gas Pump Stopped!!");
        }
    }
}
