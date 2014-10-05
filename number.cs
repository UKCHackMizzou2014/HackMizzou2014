using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity_Code
{
    class number : IProgrammingPiece
    {
        int Number ;

        public number(int i)
        {
            Number = i;
        }

        public int Execute()
        {
            return Number;
        }
    }
}
