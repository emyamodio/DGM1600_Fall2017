using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {

public string stopLight = "Red";

void Start(){
	Main();
}
void Main() {

	if(stopLight == "Red"){
	print("STOP! The light is Red!");
	}
	else if (stopLight == "Yellow" ){
		print("Slow Down!");
	}
	else if (stopLight == "Green"){
		print("Green means Go!");
		//This is the if clause, this clause it used to verify if a clause is true or false.//
		//In this case if the clause REd is true the prop will sai stop, if it's false it will defult to yellow or green//
	}
	else{
		print("I Dont know what you mean!"); 
		//This is the else clause, it's a final statement, that is used an the end of the if clause.//
		//If all other clauses fail this will be the last defult resort// 
		 
	}

}

//Conventionalr is the way you write a script, like coursive in the case of litterature,//
//it's a pretty and neet way to write a code to make it easy on your team to read.//
//While the Syntax is the grammer you have to use to be able to write a script,//
//Like having to put in order the access modifier the type and the value//
// or the semicolen at the end of evey script pice or cloasing the pice in parenthesis.// 

}