using PilotGaea.Serialize;
using PilotGaea.TMPEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckServerDocmd
{
    public class Program : DoCmdBaseClass
    {
        VarStruct varStruct = new VarStruct();

        public Program()
        {
        }
        public override bool Init()
        {
            return true;
        }
        public override void DeInit()
        {
        }
        public override bool DoCmd(CGeoDatabase DB, string Cmd, string SessionID, VarStruct InputParm, out VarStruct RetParm)
        {
            RetParm = new VarStruct();
            bool docmd = false;

            switch (Cmd)
            {
                case "isLive":
                    docmd = true;
                    break;
            }
            return docmd;
        }
        public override string[] GetSupportCmds()
        {
            //Check DoCommand有哪些方法
            string[] varGetAll = new string[] { "isLive" };//

            return varGetAll;
        }
    }
}
