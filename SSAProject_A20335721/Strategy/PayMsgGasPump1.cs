using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class PayMsgGasPump1 : PayMsg
    {
        public override void PrintPayMessage()
        {
            Console.WriteLine("Please Select to pay by\n\t3. Credit \n\t7. Cash");
        }
    }
}
