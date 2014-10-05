
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using AssemblyCSharp;
using UnityEngine;
using Unity_Code;


public class test : MonoBehaviour
    {

	MainPiece main;
	
	void Start()
        {

			main = new MainPiece();    
			

		variablelist.VariableDict.Add ('a', new number(0));

		AssignmentOperator thisaction = new AssignmentOperator(VariableDict['a'], new AddOperator(new number(6),new number(5)));


		main.addCode (thisaction);
		this.Run();


        }

	void Update()
	{

		//listen for event and add it to the main
		//if button is pressed run the code


	}


	void Run()
	{
		main.Execute();

		foreach(KeyValuePair<char, number> value in VariableDict)
		{
			//todo: modify to be done however most things are handled!
			Debug.Log("Variable " + value.Key + ": " + value.Value.Execute());

		}
	}

	public bool AssignVariable(char assignment, int value)
	{
		switch (assignment)
		{
		case 'a':
			if (variablelist.VariableDict.ContainsKey('a')) variablelist.VariableDict.Remove('a');
			variablelist.VariableDict.Add(assignment,new number(value));
			return true;
		case 'b':
			if (variablelist.VariableDict.ContainsKey('b')) variablelist.VariableDict.Remove('b');
			variablelist.VariableDict.Add(assignment,new number(value));
			return true;
		case 'c':
			if (variablelist.VariableDict.ContainsKey('c')) variablelist.VariableDict.Remove('c');
			variablelist.VariableDict.Add(assignment,new number(value));
			return true;
		case 'd':
			if (variablelist.VariableDict.ContainsKey('d')) variablelist.VariableDict.Remove('d');
			variablelist.VariableDict.Add(assignment,new number(value));
			return true;
		case 'e':
			if (variablelist.VariableDict.ContainsKey('e')) variablelist.VariableDict.Remove('e');
			variablelist.VariableDict.Add(assignment,new number(value));
			return true;
		default:
			return false;
		}
		
	}




 }