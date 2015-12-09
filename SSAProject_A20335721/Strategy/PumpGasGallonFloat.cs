using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class PumpGasGallonFloat : PumpGasUnit
    {
        public override void getPumpGasUnit(DataStore dataStore)
        {
            dataStore.setG(dataStore.getG() + 1);
            Console.WriteLine("G:"+ dataStore.getG());
            Console.WriteLine("Price :"+dataStore.getFloatPrice());
            dataStore.setFloatTotal(dataStore.getFloatPrice() * dataStore.getG());
            Console.WriteLine("Total Amount :" + dataStore.getFloatTotal());
        }
    }
}
