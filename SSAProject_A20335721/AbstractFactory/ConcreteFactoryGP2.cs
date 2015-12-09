using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.AbstractFactoryNS
{
    public class ConcreteFactoryGP2 : AbstractFactory
    {
        private DataStoreGP2 dataStoreGP2;
                       
        private StoreDataGasPump2 storeDataGasPump2;

        private PrintReceipt printReceipt;
        
        private PayMsgGasPump2 payMsgGasPump2;

        private DisplayMenuGasPump2 displayMenuGasPump2;

        private StopMsg stopMsg;

        private RejectMsgGasPump1 rejectMsgGasPump1;

        private SetWGasPump1 setWGasPump1;

        private CancelMsg1 showCancelMsg1;

        private SetPriceGasPump2 setPriceGasPump2;

        private SetInitialValuesGasPump1 setInitialValuesGasPump2;
            
        private ReadyMsgImpl readyMessage;

        private PumpGasGallonFloat pumpGasGallonFloat;

        private GasPumpedMsg gasPumpedMsg;

        
        public ConcreteFactoryGP2()
        {
            storeDataGasPump2 = new StoreDataGasPump2();
            stopMsg = new StopMsgImpl();
            printReceipt = new PrintReceiptImplGasPump2();
            dataStoreGP2 = new DataStoreGP2();
            payMsgGasPump2 = new PayMsgGasPump2();
            rejectMsgGasPump1 = new RejectMsgGasPump1();
            setWGasPump1 = new SetWGasPump1();
            displayMenuGasPump2 = new DisplayMenuGasPump2();
            showCancelMsg1 = new CancelMsg1();
            readyMessage = new ReadyMsgImpl();
            setPriceGasPump2 = new SetPriceGasPump2();
            setInitialValuesGasPump2 = new SetInitialValuesGasPump1();
            pumpGasGallonFloat = new PumpGasGallonFloat();
            gasPumpedMsg = new GasPumpedMsgGallon();
        }



        public override DataStore getDataStoreObject()
        {
            return dataStoreGP2;
        }

        public override StoreData getStoreDataObject()
        {
            return storeDataGasPump2;
        }

        public override PayMsg getPayMsgObject()
        {
            return payMsgGasPump2;
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
            return displayMenuGasPump2;
        }

        public override CancelMsg getCancelMsgObject()
        {
            return showCancelMsg1;
        }

        public override StoreCash getStoreCashObject()
        {
            throw new NotImplementedException();
        }

        public override ReadyMsg getReadyMsgObject()
        {
            return readyMessage;
        }

        public override SetPrice getSetPriceObject()
        {
            return setPriceGasPump2;
        }

        public override SetInitialValues getSetInitialValuesObject()
        {
            return setInitialValuesGasPump2;
        }

        public override PumpGasUnit getPumpGasUnitObject()
        {
            return pumpGasGallonFloat;
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
