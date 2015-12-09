using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.States
{
    public class StartState : State
    {
        readonly int ID = 0;
        public override void Activate()
        {
            Console.WriteLine("Activate Called");
            op.StoreData();
        }

        public override int getID()
        {
            return ID;
        }
        public override void Start()
        { 
            Console.WriteLine("Invalid State");
        }

        public override void PayCredit()
        {
            //throw new NotImplementedException();
        }

        public override void Reject()
        {
            //throw new NotImplementedException();
        }

        public override void Approved()
        {
            //throw new NotImplementedException();
        }

        public override void Cancel()
        {
            //throw new NotImplementedException();
        }

        public override void PayCash()
        { 
        
        }

        public override void SelectGas(int type)
        {
            //throw new NotImplementedException();
        }

        public override void StartPump()
        {
            //throw new NotImplementedException();
        }

        public override void Pump()
        {
            //throw new NotImplementedException();
        }

        public override void StopPump()
        {
            //throw new NotImplementedException();
        }

        public override void Receipt()
        {
            //throw new NotImplementedException();
        }

        public override void NoReceipt()
        {
            //throw new NotImplementedException();
        }
    }
}
