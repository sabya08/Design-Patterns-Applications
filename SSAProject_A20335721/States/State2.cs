using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.States
{
    public class State2 : State
    {
        readonly int ID = 3;
        public override void Activate()
        {
            //throw new NotImplementedException();
        }
        public override int getID()
        {
            return ID;

        }

        public override void Start()
        {
            //throw new NotImplementedException();
        }

        public override void PayCredit()
        {
            //throw new NotImplementedException();
        }

        public override void Reject()
        {
            op.RejectMsg();
        }

        public override void Approved()
        {
            op.SetW();
            op.DisplayMenu();
        }

        public override void Cancel()
        { 
            
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
