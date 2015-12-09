using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class SetInitialValuesGasPump1 : SetInitialValues
    {
        public override void setInitialValues(DataStore dataStore)
        {
            dataStore.setG(0);
            dataStore.setTotal(0);
        }
    }
}
