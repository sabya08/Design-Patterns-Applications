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
    public class GasPump3 
    {
        MDEFSMGasPump mdefsmGasPump;
        ConcreteFactoryGP3 factory;
        

        public GasPump3()
        {
            mdefsmGasPump = new MDEFSMGasPump();
            factory = new ConcreteFactoryGP3();
            DataStoreGP3.abstractFactory = factory;
        }

        public void Activate(float a, float b)
        {
            if (a > 0 && b > 0)
            {
                DataStoreGP3 dataStoreGP3 = (DataStoreGP3)factory.getDataStoreObject();
                dataStoreGP3.Tempa = a;
                dataStoreGP3.Tempb = b;
                mdefsmGasPump.Activate();
            }
        }
        public void Start()
        {
            mdefsmGasPump.Start();
        }

        public void PayCash(float c)
        {
            if (c > 0)
            {
                DataStoreGP3 dataStoreGP3 = (DataStoreGP3)factory.getDataStoreObject();
                dataStoreGP3.Temp_c = c;
                dataStoreGP3.Temp_W = 0;
                mdefsmGasPump.PayCash();

            }
        }

        public void Reject()
        {
            mdefsmGasPump.Reject();
        }
               

        public void Cancel()
        {
            mdefsmGasPump.Cancel();
        }

        public void Premium()
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

        public void PumpLiter()
        {
            Console.WriteLine("Pump Liter called!!");
            DataStoreGP3 dataStoreGP3 = (DataStoreGP3)factory.getDataStoreObject();
            if (dataStoreGP3.getFloatCash() < (dataStoreGP3.getL() + 1) * dataStoreGP3.getFloatPrice())
            {
                mdefsmGasPump.StopPump();
                //mdefsmGasPump.Receipt();
            }
            else
            {
                mdefsmGasPump.Pump();

            }

        }

        public void StopPump()
        {
            mdefsmGasPump.StopPump();
            
        }

        public void Receipt()
        {
            mdefsmGasPump.Receipt();
        }

        public void NoReceipt()
        {
            mdefsmGasPump.NoReceipt();
        }
    }
}
