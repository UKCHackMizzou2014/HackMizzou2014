using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Code
{
    class number : ProgrammingPiece
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
