
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using AssemblyCSharp;
using UnityEngine;
using Unity_Code;


public static class test : MonoBehaviour
    {
		
	public static Dictionary<char, number> VariableDict;

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
	MainPiece main;
	
	void Start()
        {
		VariableDict = new Dictionary<char, number>;
			main = new MainPiece();        

        }

		void Update()
		{

		//listen for event and add it to the main
		//if button is pressed run the code


		}
    }