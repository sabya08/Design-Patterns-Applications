using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.AbstractFactoryNS
{
    public class ConcreteFactoryGP1 : AbstractFactory
    {
        private DataStoreGP1 dataStoreGP1;

        

        private StoreDataGasPump1 storeDataGasPump1;

        

        private PayMsgGasPump1 payMsgGasPump1;

        

        private RejectMsgGasPump1 rejectMsgGasPump1;

        

        private SetWGasPump1 setWGasPump1;

        

        private DisplayMenuGasPump1 displayMenuGasPump1;

        

        private CancelMsg1 showCancelMsg1;

        

        private StoreCashGasPump1 storeCashGasPump1;

       


        private SetPrice setPriceGasPump1;

        

        private SetInitialValues setInitialValuesObject;

        

        private ReadyMsg readyMsgObject;

        
        private PumpGasUnit pumpGasUnitObject;

        

        private StopMsg stopMsg;

        

        private PrintReceipt printReceipt;

        private GasPumpedMsg gasPumpedMsg;
        


        public ConcreteFactoryGP1()
        { 
            dataStoreGP1 = new DataStoreGP1();
            storeDataGasPump1 = new StoreDataGasPump1();
            payMsgGasPump1 = new PayMsgGasPump1();
            rejectMsgGasPump1 = new RejectMsgGasPump1();
            setWGasPump1 = new SetWGasPump1();
            displayMenuGasPump1 = new DisplayMenuGasPump1();
            showCancelMsg1 = new CancelMsg1();
            storeCashGasPump1 = new StoreCashGasPump1();
            setPriceGasPump1 = new SetPriceGasPump1();
            readyMsgObject = new ReadyMsgImpl();
            setInitialValuesObject = new SetInitialValuesGasPump1();
            pumpGasUnitObject = new PumpGasGallon();
            stopMsg = new StopMsgImpl();
            printReceipt = new PrintReceiptImpl();
            gasPumpedMsg = new GasPumpedMsgGallon();

        }
        public override DataStore getDataStoreObject()
        {
            return dataStoreGP1;
        }

        public override StoreData getStoreDataObject()
        {
            return storeDataGasPump1;
        }

        public override PayMsg getPayMsgObject()
        {
            return payMsgGasPump1;
        }

        public override RejectMsg getRejectMsgObject()
        {
            return rejectMsgGasPump1;
        }

        public override SetW getSetWObject()
        {
            return setWGasPump1;
        }

        public override DisplayMenu getDisplayMenuObject()
        {
            return displayMenuGasPump1;
        }

        public override CancelMsg getCancelMsgObject()
        {
            return showCancelMsg1;
        }

        public override StoreCash getStoreCashObject()
        {
            return storeCashGasPump1;
        }

        public override SetPrice getSetPriceObject()
        {
            return setPriceGasPump1;            
        }

        public override SetInitialValues getSetInitialValuesObject()
        {
            return setInitialValuesObject;
        }

        public override ReadyMsg getReadyMsgObject()
        {
            return readyMsgObject;
        }

        public override PumpGasUnit getPumpGasUnitObject()
        {
            return pumpGasUnitObject;
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
