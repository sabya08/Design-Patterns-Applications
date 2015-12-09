using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class StoreDataGasPump3 : StoreData
    {
        public override void StoreDataInDataStore(DataStore dataStore)
        {
            dataStore.setRPrice(dataStore.getTempa());
            dataStore.setSPrice(dataStore.getTempb());
            Console.WriteLine("Price of regular price" + dataStore.getTempa());
            Console.WriteLine("Price of premium price" + dataStore.getTempb());
        }
    }
}
