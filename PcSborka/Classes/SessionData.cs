using PcSborka.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcSborka.Classes
{
    class SessionData
    {
        public class ComputerReady
        {
            public static CPU CPUID { get; set; }
            public static MotherBoard MotherBoardID { get; set; }
            public static Case CaseID { get; set; }
            public static GPU GPUID { get; set; }
            public static Cooler CoolerID { get; set; }
            public static RAM RAMID { get; set; }
            public static PowerSupply PowerSupplyID { get; set; }

            public ComputerReady(CPU cPU,MotherBoard motherBoard,Case cas,GPU gPU,Cooler cooler, RAM rAM, PowerSupply powerSupply)
            {
                CPUID = cPU;
                MotherBoardID = motherBoard;
                CaseID = cas;
                GPUID = gPU;
                CoolerID = cooler;
                RAMID = rAM;
                PowerSupplyID = powerSupply;
            }

            public bool CheckSocket()
            {
                bool isExist = false;

                if (CPUID != null)
                {
                    isExist = true;
                }

                return isExist;
            }

            public bool CheckForm_factor()
            {
                bool isExist = false;

                if(MotherBoardID!=null)
                {
                    isExist = true;
                }

                return isExist;
            }
                
            public bool CheckTypeMotherBoard()
            {
                bool isExist = false;

                if(CoolerID !=null)
                {
                    isExist = true;
                }

                return isExist;
            }

            

            public ComputerReady() { }
        }
    }
}
