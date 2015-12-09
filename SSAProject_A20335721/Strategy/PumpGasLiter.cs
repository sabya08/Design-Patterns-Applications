using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class PumpGasLiter : PumpGasUnit
    {
        public override void getPumpGasUnit(DataStore dataStore)
        {
            dataStore.setL(dataStore.getL() + 1);
            Console.WriteLine("L:" + dataStore.getL());
            Console.WriteLine("Price :" + dataStore.getFloatPrice());
            dataStore.setFloatTotal(dataStore.getFloatPrice() * dataStore.getL());
            Console.WriteLine("Total Amount :" + dataStore.getFloatTotal());
        }
    }
}
