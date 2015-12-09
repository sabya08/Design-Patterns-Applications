using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class SetInitialValuesGasPump3 : SetInitialValues
    {
        public override void setInitialValues(DataStore dataStore)
        {
            dataStore.setL(0);
            dataStore.setFloatTotal(0);
            Console.WriteLine("Initial Values of L = "+dataStore.getL()+" and total = "+dataStore.getFloatTotal());
        }
    }
}
