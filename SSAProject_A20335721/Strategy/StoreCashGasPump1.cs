using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class StoreCashGasPump1 : StoreCash
    {
        public override void StoreCashInDataStore(DataStore dataStore)
        {
            
            dataStore.set_c(dataStore.getTemp_c());
            
            Console.WriteLine("Cash Value -- "+dataStore.get_c());
        }
    }
}
