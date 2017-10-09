using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//LogicalOperations allow a person to compare values; 
//In a logical operation all (both) statements must be true or the code will not run
public class LogicalOP : MonoBehaviour {
	// public string luke = "Jedi";

	// public string vader = "Sith";

	// public bool leia = true;

	// public string darkSide = "Darth Maul";

	// public string lightSide = "Obi Wan";

	// public int num1 = 10;

	// public float num2 = 10.5f;

	public string redRoses = "Love";

	public string blackRoses = "Death";

	// Use this for initialization
	void Start () {
		// if(luke == "Jedi" && vader == "Nanny"){
		// 	print("Vaders yo Nanny!");
		// }	
		// else if (luke == "Jawa" && vader == "Sith"){
		// 	print ("Utinni!");
		// }
		// else if(luke == "Jedi" && vader == "Sith"){
		// 	print("Nooooooooooooo! That's not true...That's impossible!");
		// }
		// else{
		// 	print("The End!");
		// }

		// if(leia){
		// 	print("No, there is another.");
		// }
		// else if(!leia){
		// 	print("Hurray! Now I can date Luke");
		// }
		// else
		// 	print("Han fired first!");

		// if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
		// 	print("Meeeza Evil Bad Bad Sith Lorde");
		// }
		// else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
		// 	print("As you wish, my master");
		// }
		// else{
		// 	print("Not the younglings!");
		// }

		// if(num1 == 10 && num2 == 10.5){
		// 	print("Yes!");
		// }
		// else if(num1 == 10 && num2 == 10){
		// 	print("NOOOOOO!");
		// }
		// else{
		// 	print("Utinni!");
		// }

		if(redRoses == "Love" && blackRoses == "Funeral"){
			print("We are having a loving funeral");
		}	
		else if (redRoses == "Frendship" && blackRoses == "Death"){
			print ("It'a a deadly frenship");
		}
		else if(redRoses == "Love" && blackRoses == "Death"){
			print("The tragedy of Romeo of Juliet");
		}
		else{
			print("The End!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
