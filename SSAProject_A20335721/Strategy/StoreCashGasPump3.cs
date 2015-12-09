using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class StoreCashGasPump3 : StoreCash
    {
        public override void StoreCashInDataStore(DataStore dataStore)
        {

            dataStore.setFloatCash(dataStore.getTempFloatc());

            Console.WriteLine("Cash Value -- " + dataStore.getFloatCash());
        }
    }
}
