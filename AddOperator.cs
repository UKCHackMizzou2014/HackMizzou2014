﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    class AddOperator : IProgrammingPiece
    {
        private IProgrammingPiece left;
        private IProgrammingPiece right;

        public AddOperator(IProgrammingPiece one, IProgrammingPiece two)
        {
            left = one;
            right = two;
            

        }

        public int Execute()
        {
            return right.Execute() + left.Execute();
        }
    }
}
