﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class SetWGasPump1 : SetW
    {
        public override void StoreW(DataStores.DataStore dataStore)
        {
            dataStore.setW(dataStore.getTemp_w());
            Console.WriteLine("Value of W" +dataStore.getW());
        }
    }
}
