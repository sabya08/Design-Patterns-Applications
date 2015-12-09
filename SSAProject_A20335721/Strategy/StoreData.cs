﻿using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public abstract class StoreData
    {
        public abstract void StoreDataInDataStore(DataStore dataStore);
    }
}
