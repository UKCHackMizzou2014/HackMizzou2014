using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    public class ForLoop : IProgrammingPiece
    {
        private int index;
        private int ceiling;
        private ArrayList loopArray;

        public ForLoop(int index, int ceiling)
        {
            loopArray = new ArrayList();
            this.index = index;
            this.ceiling = ceiling;



        }

        public void addCommand(IProgrammingPiece addedcommand)
        {
            loopArray.Add(addedcommand);
        }

        public int Execute()
        {


            for (int i = index; i < ceiling; i++) 
            {
                foreach (IProgrammingPiece curCommand in loopArray)
                {
                    curCommand.Execute();
                }
            }

            return 0;

        }
    }
}
