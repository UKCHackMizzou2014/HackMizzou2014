using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AssemblyCSharp;

namespace Unity_Code
{
    public class AssignmentOperator : IProgrammingPiece
    {

        private number assignment;
		private char key;

        public AssignmentOperator(char key, IProgrammingPiece rightSide)
        {
			this.key = key;
			assignment = new number(rightSide.Execute());
        }

        public int Execute()
        {
			variablelist.VariableDict [key] =  assignment.Execute();

			return 0;
        }
    }
}
