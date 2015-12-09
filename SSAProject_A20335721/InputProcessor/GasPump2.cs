using SSAProject_A20335721.AbstractFactoryNS;
using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.MDEFSM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.InputProcessor
{
    public class GasPump2
    {
        DataStore dataStore;

        public DataStore DataStore
        {
            get { return dataStore; }
            set { dataStore = value; }
        }

        private AbstractFactory factory;

        public AbstractFactory Factory
        {
            get { return factory; }
            set { factory = value; }
        }
        private MDEFSMGasPump mdefsmGasPump;

        public MDEFSMGasPump MdefsmGasPump
        {
            get { return mdefsmGasPump; }
            set { mdefsmGasPump = value; }
        }
        public GasPump2()
        {
            mdefsmGasPump = new MDEFSMGasPump();
            factory = new ConcreteFactoryGP2();
            DataStoreGP2.abstractFactory = factory;

        }

        public void Activate(float a, float b)
        {
            if (a > 0 && b > 0)
            {
                DataStoreGP2 dataStoreGP2 = (DataStoreGP2)factory.getDataStoreObject();
                dataStoreGP2.Tempa = a;
                dataStoreGP2.Tempb = b;
                mdefsmGasPump.Activate();
            }
        }

        public void Start()
        {
            mdefsmGasPump.Start();
        }

        public void PayCredit()
        {
            mdefsmGasPump.PayCredit();
        }

        public void Reject()
        {
            mdefsmGasPump.Reject();
        }

        public void Approved()
        {
            DataStoreGP2 dataStoreGP2 = (DataStoreGP2)factory.getDataStoreObject();
            dataStoreGP2.Temp_W = 1;
            mdefsmGasPump.Approved();

        }

        public void Cancel()
        {
            mdefsmGasPump.Cancel();
        }

        public void Super()
        {
            mdefsmGasPump.SelectGas(2);
        }

        public void Regular()
        {
            mdefsmGasPump.SelectGas(1);
        }


        public void StartPump()
        {
            Console.WriteLine("Start Pump");
            
            mdefsmGasPump.StartPump();
        }

        public void PumpGallon()
        {
            Console.WriteLine("Pump Gallon called!!");
            DataStoreGP2 dataStoreGP2 = (DataStoreGP2)factory.getDataStoreObject();
            mdefsmGasPump.Pump();        

        }

        public void StopPump()
        {
            mdefsmGasPump.StopPump();
            mdefsmGasPump.Receipt();
        }
    }
}
