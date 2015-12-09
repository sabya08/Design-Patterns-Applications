using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class SetPriceGasPump2 : SetPrice
    {

        public override void setPriceForGasPump(int type, DataStores.DataStore dataStore)
        {
            if (type == 1)
            {
                dataStore.setFloatPrice(dataStore.getRPrice());
                //Console.WriteLine(dataStore.getFloatPrice());
                Console.WriteLine("Price of Regular Gas :" + dataStore.getFloatPrice());
            }
            if (type == 2)
            {
                dataStore.setFloatPrice(dataStore.getSPrice());
                //Console.WriteLine(dataStore.getFloatPrice());
                Console.WriteLine("Price of Super Gas :" + dataStore.getFloatPrice());
            }
        }
    }
}
