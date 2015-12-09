using SSAProject_A20335721.AbstractFactoryNS;
using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.OutputProcessor
{
    public class OutputProcessorClass
    {
        AbstractFactory abstractFactory = null;
        DataStore dataStore;
        StoreData storeData;
        PayMsg payMsg;
        RejectMsg rejectMsg;
        SetW setW;
        DisplayMenu displayMenu;
        CancelMsg cancelMsg;
        StoreCash storeCash;
        SetPrice setPrice;
        SetInitialValues setInitialValuesobj;
        ReadyMsg readyMsg;
        PumpGasUnit pumpGasUnit;
        StopMsg stopMsg;
        PrintReceipt printReceipt;
        GasPumpedMsg gasPumpedMsg;
        public void StoreData()
        {
            abstractFactory= DataStore.abstractFactory;
            storeData = abstractFactory.getStoreDataObject();
            dataStore = abstractFactory.getDataStoreObject();
            storeData.StoreDataInDataStore(dataStore);
            
            
        }

        public void PayMsg()
        {
            abstractFactory = DataStore.abstractFactory;
            payMsg = abstractFactory.getPayMsgObject();
            payMsg.PrintPayMessage();
        }

        public void PayCredit()
        {
            Console.WriteLine("Waiting for Approval. Select one of the follwoing option.\n\t4. Reject\n\t5. Cancel\n\t6. Approve");
        }

        public void RejectMsg()
        {
            abstractFactory = DataStore.abstractFactory;
            rejectMsg = abstractFactory.getRejectMsgObject();
            rejectMsg.printRejectMsg();
        }

        public void SetW()
        {
            abstractFactory = DataStore.abstractFactory;
            dataStore = abstractFactory.getDataStoreObject();
            setW = abstractFactory.getSetWObject();
            setW.StoreW(dataStore);
        }

        public void DisplayMenu()
        {
            abstractFactory = DataStore.abstractFactory;
            
            displayMenu = abstractFactory.getDisplayMenuObject();
            displayMenu.showMenu();
        }

        public void CancelMsg()
        {
            abstractFactory = DataStore.abstractFactory;
            cancelMsg = abstractFactory.getCancelMsgObject();
            cancelMsg.showCancelMsg();
        }

        public void StoreCash()
        {
            abstractFactory = DataStore.abstractFactory;
            dataStore = abstractFactory.getDataStoreObject();
            storeCash = abstractFactory.getStoreCashObject();
            storeCash.StoreCashInDataStore(dataStore);

        }

        public void SetPrice(int type)
        {
            abstractFactory = DataStore.abstractFactory;
            setPrice = abstractFactory.getSetPriceObject();
            dataStore = abstractFactory.getDataStoreObject();
            setPrice.setPriceForGasPump(type, dataStore);
        }

        public void setInitialValues()
        {
            abstractFactory = DataStore.abstractFactory;
            dataStore = abstractFactory.getDataStoreObject();
            
            setInitialValuesobj = abstractFactory.getSetInitialValuesObject();
            setInitialValuesobj.setInitialValues(dataStore);
            
        }

        public void readyMessage()
        {
            abstractFactory = DataStore.abstractFactory;
            readyMsg = abstractFactory.getReadyMsgObject();
            readyMsg.printReadyMsg();
        }

        public void PumpGasUnit()
        {
            abstractFactory = DataStore.abstractFactory;
            dataStore = abstractFactory.getDataStoreObject();
            pumpGasUnit = abstractFactory.getPumpGasUnitObject();
            pumpGasUnit.getPumpGasUnit(dataStore);
        }

        public void StopMessage()
        {
            abstractFactory = DataStore.abstractFactory;
            stopMsg = abstractFactory.getStopMsgObject();
            stopMsg.printStopMsg();
        }

        public void PrintReceipt()
        {
            abstractFactory = DataStore.abstractFactory;
            printReceipt = abstractFactory.getPrintReceiptObject();
            dataStore = abstractFactory.getDataStoreObject();
            printReceipt.printReceipt(dataStore);
        }

        public void NoReceipt()
        {
            Console.WriteLine("No Receipt to print!");
        }

        public void GasPumpedMsg()
        {
            abstractFactory = DataStore.abstractFactory;
            gasPumpedMsg = abstractFactory.getGasPumpedMsgObject();
            dataStore = abstractFactory.getDataStoreObject();
            gasPumpedMsg.diplayPumpedGas(dataStore);

        }

        
    }
}
