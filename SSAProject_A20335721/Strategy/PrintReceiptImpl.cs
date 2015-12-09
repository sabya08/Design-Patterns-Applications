using SSAProject_A20335721.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class PrintReceiptImpl : PrintReceipt
    {
        public override void printReceipt(DataStore dataStore)
        {
            Console.WriteLine("*******RECEIPT******");
            Console.WriteLine("Your Total Amount for " + dataStore.getG() + " unit of gas is " + dataStore.getTotal());
        }
    }
}
