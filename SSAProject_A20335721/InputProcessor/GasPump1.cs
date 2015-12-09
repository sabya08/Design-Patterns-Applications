using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSAProject_A20335721.DataStores;
using SSAProject_A20335721.AbstractFactoryNS;
using SSAProject_A20335721.MDEFSM;

namespace SSAProject_A20335721.InputProcessor
{
    public class GasPump1
    {
        private DataStore dataStore;

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

        public GasPump1()
        {
            mdefsmGasPump = new MDEFSMGasPump();
            factory = new ConcreteFactoryGP1();
            DataStoreGP1.abstractFactory = factory;
        }
        public void Activate(int a)
        {
            if (a > 0)
            {                
                DataStoreGP1 dataStoreGP1 = (DataStoreGP1)factory.getDataStoreObject();
                dataStoreGP1.Temp_a = a;
                //Console.WriteLine(dataStoreGP1.Temp_a);                
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
            DataStoreGP1 dataStoreGP1 = (DataStoreGP1)factory.getDataStoreObject();
            dataStoreGP1.Temp_W = 1;
            mdefsmGasPump.Approved();

        }

        public void Cancel()
        {
            mdefsmGasPump.Cancel();
        }

       
        public void PayCash(int c)
        {
            if (c > 0)
            {
                DataStoreGP1 dataStoreGP1 = (DataStoreGP1)factory.getDataStoreObject();
                dataStoreGP1.Temp_c = c;
                dataStoreGP1.Temp_W = 0;
                mdefsmGasPump.PayCash();

            }
        }

        public void StartPump()
        {
            Console.WriteLine("Start Pump");
            //DataStoreGP1 dataStoreGP1 = (DataStoreGP1)factory.getDataStoreObject();
            mdefsmGasPump.SelectGas(1);
            //dataStoreGP1.Temp_G = 0;
            mdefsmGasPump.StartPump();
        }

        public void PumpGallon()
        {
            Console.WriteLine("Pump Gallon called!!");
            DataStoreGP1 dataStoreGP1 = (DataStoreGP1)factory.getDataStoreObject();
            if (dataStoreGP1.getW() == 1)
            {
                mdefsmGasPump.Pump();
                
            }
            else if (dataStoreGP1.get_c() < (dataStoreGP1.getG() + 1) * dataStoreGP1.getActualPrice())
            {
                mdefsmGasPump.StopPump();
                mdefsmGasPump.Receipt();
            }
            else
            {
                mdefsmGasPump.Pump();
                
            }

        }

        public void StopPump()
        {
            mdefsmGasPump.StopPump();
            mdefsmGasPump.Receipt();
        }
    }
}
