using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.AbstractFactoryNS
{
    public abstract class AbstractFactory
    {

        public abstract DataStore getDataStoreObject();

        public abstract StoreData getStoreDataObject();

        public abstract PayMsg getPayMsgObject();

        public abstract RejectMsg getRejectMsgObject();

        public abstract SetW getSetWObject();

        public abstract DisplayMenu getDisplayMenuObject();

        public abstract CancelMsg getCancelMsgObject();

        public abstract StoreCash getStoreCashObject();

        public abstract SetPrice getSetPriceObject();

        public abstract SetInitialValues getSetInitialValuesObject();

        public abstract ReadyMsg getReadyMsgObject();

        public abstract PumpGasUnit getPumpGasUnitObject();

        public abstract StopMsg getStopMsgObject();

        public abstract PrintReceipt getPrintReceiptObject();

        public abstract GasPumpedMsg getGasPumpedMsgObject();

    }
}
