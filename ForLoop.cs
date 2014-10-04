using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    public class ForLoop : ProgrammingPiece
    {
        private int index;
        private int ceiling;
        private ArrayList loopArray;

        public ForLoop(int index, int ceiling)
        {
            this.index = index;
            this.ceiling = ceiling;



        }

        public void addCommand(ProgrammingPiece addedcommand)
        {
            loopArray.Add(addedcommand);
        }

        public int Execute()
        {

            for (int i = index; i < ceiling; i++) ;
            {
                foreach (ProgrammingPiece curCommand in loopArray)
                {
                    curCommand.Execute();
                }
            }

            return 0;

        }
    }
}
