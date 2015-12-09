using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.AbstractFactoryNS
{
    public class ConcreteFactoryGP3 : AbstractFactory
    {
        private GasPumpedMsg gasPumpedMsg;

        private PrintReceipt printReceipt;
        
        private PayMsgGasPump3 payMsgGasPump3;
        
        private DisplayMenuGasPump3 displayMenuGasPump3;
        
        private StopMsg stopMsg;

        private DataStoreGP3 dataStoreGP3;

        private StoreDataGasPump3 storeDataGasPump3;

        private StoreCashGasPump3 storeCashGasPump3;

        private SetWGasPump1 setWGasPump3;

        private CancelMsg1 cancelMessage;

        private SetPriceGasPump2 setPrice;

        private SetInitialValuesGasPump3 setInititalValues;

        private ReadyMsgImpl readyMsg;

        private PumpGasLiter pumpGasLiter;

        
        
        public ConcreteFactoryGP3()
        {
            stopMsg = new StopMsgImpl();
            printReceipt = new PrintReceiptImplGasPump3();
            gasPumpedMsg = new GasPumpedMsgLiter();
            dataStoreGP3 = new DataStoreGP3();
            storeDataGasPump3 = new StoreDataGasPump3();
            payMsgGasPump3 = new PayMsgGasPump3();
            storeCashGasPump3 = new StoreCashGasPump3();
            displayMenuGasPump3 = new DisplayMenuGasPump3();
            setWGasPump3 = new SetWGasPump1();
            cancelMessage = new CancelMsg1();
            setPrice = new SetPriceGasPump2();
            setInititalValues = new SetInitialValuesGasPump3();
            readyMsg = new ReadyMsgImpl();
            pumpGasLiter = new PumpGasLiter();
        }

        

        

        public override DataStore getDataStoreObject()
        {
            return dataStoreGP3;
        }

        public override StoreData getStoreDataObject()
        {
            return storeDataGasPump3;
        }

        public override PayMsg getPayMsgObject()
        {
            return payMsgGasPump3;
        }

        public override RejectMsg getRejectMsgObject()
        {
            throw new NotImplementedException();
        }

        public override SetW getSetWObject()
        {
            return setWGasPump3;
            
        }

        public override DisplayMenu getDisplayMenuObject()
        {
            return displayMenuGasPump3;
        }

        public override CancelMsg getCancelMsgObject()
        {
            return cancelMessage;
        }

        public override StoreCash getStoreCashObject()
        {
            return storeCashGasPump3;
        }

        public override ReadyMsg getReadyMsgObject()
        {
            return readyMsg;
        }

        public override SetPrice getSetPriceObject()
        {
            return setPrice;
        }

        public override SetInitialValues getSetInitialValuesObject()
        {
            return setInititalValues;
        }

        public override PumpGasUnit getPumpGasUnitObject()
        {
            return pumpGasLiter;
        }

        public override StopMsg getStopMsgObject()
        {
            return stopMsg;
        }

        public override PrintReceipt getPrintReceiptObject()
        {
            return printReceipt;
        }

        public override GasPumpedMsg getGasPumpedMsgObject()
        {
            return gasPumpedMsg;
        }
    }
}
