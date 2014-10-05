using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Unity_Code
{
    class SubtractOperator : IProgrammingPiece
    {
        private IProgrammingPiece left;
        private IProgrammingPiece right;

        public SubtractOperator(IProgrammingPiece left, IProgrammingPiece right)
        {
            this.left = left;
            this.right = right;


        }

        public int Execute()
        {
            return left.Execute() - right.Execute();
        }
    }
}
