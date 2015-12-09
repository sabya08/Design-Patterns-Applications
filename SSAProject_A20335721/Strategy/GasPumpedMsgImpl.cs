using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class GasPumpedMsgGallon :  GasPumpedMsg
    {
        public override void diplayPumpedGas(DataStore dataStore)
        {
            Console.WriteLine("Amount of pumped gas disposed is :" + dataStore.getG() + " gallons.");
        }

    }
}
