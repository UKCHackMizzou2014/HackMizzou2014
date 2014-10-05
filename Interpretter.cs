using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity_Code
{
    class Interpretter
    {

        private Dictionary<char, int> VariableDict;
        private List<IProgrammingPiece> commandList;

        public Interpretter()
        {
            VariableDict = new Dictionary<char, int>();
            commandList = new List<IProgrammingPiece>();
        }


        public void AddCommand(IProgrammingPiece command)
        {
            commandList.Add(command);
            
        }

        public void RemoveCommand(int i)
        {
            commandList.RemoveAt(i);
        }

        public bool AssignVariable(char assignment, int value)
        {
            switch (assignment)
            {
                case 'a':
                    if (VariableDict.ContainsKey('a')) VariableDict.Remove('a');
                    VariableDict.Add(assignment,value);
                    return true;
                case 'b':
                    if (VariableDict.ContainsKey('b')) VariableDict.Remove('b');
                    VariableDict.Add(assignment,value);
                    return true;
                case 'c':
                    if (VariableDict.ContainsKey('c')) VariableDict.Remove('c');
                    VariableDict.Add(assignment, value);
                    return true;
                case 'd':
                    if (VariableDict.ContainsKey('d')) VariableDict.Remove('d');
                    VariableDict.Add(assignment, value);
                    return true;
                case 'e':
                    if (VariableDict.ContainsKey('e')) VariableDict.Remove('e');
                    VariableDict.Add(assignment, value);
                    return true;
                default:
                    return false;
            }

        }












    }
}
