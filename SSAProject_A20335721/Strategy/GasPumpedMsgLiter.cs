using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class GasPumpedMsgLiter : GasPumpedMsg
    {
        public override void diplayPumpedGas(DataStores.DataStore dataStore)
        {
            Console.WriteLine("Amount of pumped gas disposed is :" + dataStore.getL() + " Litres");
        }
    }
}
