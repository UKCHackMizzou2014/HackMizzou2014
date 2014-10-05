using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity_Code
{
    public class AssignmentOperator : IProgrammingPiece
    {

        private IProgrammingPiece leftSide;

        public AssignmentOperator(IProgrammingPiece assignee, IProgrammingPiece rightSide)
        {
           // leftSide = new rightSide;
        }

        public int Execute()
        {
            return 0;
            //set
        }
    }
}
