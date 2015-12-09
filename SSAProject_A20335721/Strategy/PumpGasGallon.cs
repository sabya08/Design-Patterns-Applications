using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class PumpGasGallon : PumpGasUnit
    {
        public override void getPumpGasUnit(DataStore dataStore)
        {
            dataStore.setG(dataStore.getG() + 1);
            dataStore.setTotal(dataStore.getActualPrice() * dataStore.getG());
            Console.WriteLine("Total Amount :"+dataStore.getTotal());
        }
    }
}
