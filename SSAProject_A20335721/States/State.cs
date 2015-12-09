using SSAProject_A20335721.OutputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.States
{
    public abstract class State
    {
        public OutputProcessorClass op = new OutputProcessorClass();
        public abstract void Activate();

        public abstract int getID();

        public abstract void Start();

        public abstract void PayCredit();

        public abstract void Reject();

        public abstract void Approved();

        public abstract void Cancel();

        public abstract void PayCash();

        //public abstract void SetPrice(int type);

        public abstract void SelectGas(int type);

        public abstract void StartPump();

        public abstract void Pump();

        public abstract void StopPump();

        public abstract void Receipt();

        public abstract void NoReceipt();

    }
}
