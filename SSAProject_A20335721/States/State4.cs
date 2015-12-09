using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.States
{
    public class State4 : State
    {
        readonly int ID = 5;
        public override void Activate()
        {
            throw new NotImplementedException();
        }
        public override int getID()
        {
            return ID;
        }
        public override void Start()
        {

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

        }

        public override void PayCash()
        {

        }

        public override void SelectGas(int type)
        {
            throw new NotImplementedException();
        }

        public override void StartPump()
        {
            op.setInitialValues();
            op.readyMessage();
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
