using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Unity_Code
{
    class WhileLoop : ProgrammingPiece
    {
        private ArrayList LoopArray;
        private int numRepeats = 0;

        public WhileLoop()
        {
            
        }

        public void setRepeats(int repeats)
        {
            numRepeats = repeats;

        }

        public void Execute()
        {
            int i = 0;
            while(i < numRepeats)
            {
                foreach(ProgrammingPiece curCommand in LoopArray)
                {
                    curCommand.Execute();
                }
                i++;
            }

        }

        public void addCommand(ProgrammingPiece thatPiece)
        {
            LoopArray.Add(thatPiece);
        }

        public void removeCommandatLoc(int location)
        {
            LoopArray.Remove(location);
        }
        
    }
}
