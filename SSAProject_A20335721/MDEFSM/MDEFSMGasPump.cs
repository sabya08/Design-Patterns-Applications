using SSAProject_A20335721.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.MDEFSM
{
    public class MDEFSMGasPump
    {
        State[] state;
        int stateID = 0;
        public MDEFSMGasPump()
        {
            state = new State[8];
            state[0] = new StartState();
            state[1] = new State0();
            state[2] = new State1();
            state[3] = new State2();
            state[4] = new State3();
            state[5] = new State4();
            state[6] = new State5();
            state[7] = new State6(); 
        }
         
        public void Activate()
        {
            state[stateID].Activate();
            if (state[stateID].getID() == 0)
            {
                stateID = 1;
            }
            Console.WriteLine("Activate in MDEFSM called");
        }

        public void Start()
        {
            //Console.WriteLine(stateID);
            state[stateID].Start();
            if (state[stateID].getID() == 1)
            {
                stateID = 2;
            }
            //Console.WriteLine("Start in MDEFSM called");
        }

        public void PayCredit()
        {
            state[stateID].PayCredit();
            if (state[stateID].getID() == 2)
            {
                stateID = 3;
            }
            
        }

        public void Reject()
        {
            state[stateID].Reject();
            if (state[stateID].getID() == 3)
            {
                stateID = 1;
            }
        }

        public void Approved()
        {
            state[stateID].Approved();
            if (state[stateID].getID() == 3)
            {
                stateID = 4;
            }
        }

        public void Cancel()
        {
            state[stateID].Cancel();
            if (state[stateID].getID() == 4)
            {
                stateID = 1;
            }
        }

        public void PayCash()
        {
            state[stateID].PayCash();
            if (state[stateID].getID() == 2)
            {
                stateID = 4;
            }
        }

        public void SelectGas(int type)
        {
            state[stateID].SelectGas(type);
            if (state[stateID].getID() == 4)
            {
                stateID = 5;
            }
        }

        public void StartPump()
        {
            state[stateID].StartPump();
            if (state[stateID].getID() == 5)
            {
                stateID = 6;
            }
        }

        public void Pump()
        {
            state[stateID].Pump();
            if (state[stateID].getID() == 6)
            {
                stateID = 6;
            }   
        }

        public void StopPump()
        {
            state[stateID].StopPump();
            if (state[stateID].getID() == 6)
            {
                stateID = 7;
            }    
        }

        public void Receipt()
        {
            state[stateID].Receipt();
            if (state[stateID].getID() == 7)
            {
                stateID = 1;
            }  
        }

        public void NoReceipt()
        {
            state[stateID].NoReceipt();
            if (state[stateID].getID() == 7)
            {
                stateID = 1;
            } 
        }

    }
}
