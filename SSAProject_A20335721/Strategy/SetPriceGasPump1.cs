using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class SetPriceGasPump1 : SetPrice
    {
        public override void setPriceForGasPump(int type, DataStore dataStore)
        {
            if (type == 1)
            {
                dataStore.setActualPrice(dataStore.getPrice());
                Console.WriteLine(dataStore.getPrice());
                Console.WriteLine("Price of Regular Gas :" + dataStore.getActualPrice());
            }
        }
    }
}
