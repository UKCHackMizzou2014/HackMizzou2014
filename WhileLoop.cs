using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    class WhileLoop: IProgrammingPiece
    {
        private ArrayList LoopArray;
        private int numRepeats = 0;

        public WhileLoop()
        {
            LoopArray = new ArrayList();

        }

        public void setRepeats(int repeats)
        {
            numRepeats = repeats;

        }

        public int Execute()
        {

            int i = 0;
            while(i < numRepeats)
            {
                foreach(IProgrammingPiece curCommand in LoopArray)
                {
                    curCommand.Execute();
                }
                i++;
            }

            return 0;

        }

        public void addCommand(IProgrammingPiece thatPiece)
        {
            LoopArray.Add(thatPiece);
        }

        public void removeCommandatLoc(int location)
        {
            LoopArray.Remove(location);
        }
        
    }
}
