using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    class AddOperator : ProgrammingPiece
    {
        private ProgrammingPiece left;
        private ProgrammingPiece right;

        public AddOperator(ProgrammingPiece left, ProgrammingPiece right)
        {
            
        }

        public int Execute()
        {
            int a = (int)left.Execute();
            int b = (int)right.Execute();

            return a + b;
        }

    }
}
