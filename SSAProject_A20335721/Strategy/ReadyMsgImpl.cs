﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.Strategy
{
    public class ReadyMsgImpl : ReadyMsg
    {
        public override void printReadyMsg()
        {
            Console.WriteLine("Gas pump is ready!!");

        }
    }
}
