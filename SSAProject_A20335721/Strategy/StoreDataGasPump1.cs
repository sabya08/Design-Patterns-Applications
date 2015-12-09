using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class StoreDataGasPump1 : StoreData
    {
        public override void StoreDataInDataStore(DataStore dataStore)
        {
            dataStore.setPrice(dataStore.getTemp_a());
            Console.WriteLine("==========" + dataStore.getTemp_a());
        }
    }
}
