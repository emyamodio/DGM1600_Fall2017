using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Arrays are a veriable that holds multiple collections, like a closet, storage or a travelers poket or even a banck in a game//
//The Array is indicated in the sccript form the [] sign//
//An Array is a series of slots in the game that are used to hole objects' like an egg carton//
//The first slot is indicated as the numerical value 0//
//For example you can have 6 Arrays but they will count as 5 because you start the caunt from 0//
//Example 0 1 2 3 4 5, as you can see there are 6 spots, but count 5//

//EXAMPLE 1//

public class Arrays : MonoBehaviour {

	public string[] heros = new string[6];

	
	// Use this for initialization
	void Start () {
	heros[0] = "Batman";
	heros[1] = "Superman";
	heros[2] = "Wonder Woman";
	heros[3] = "Green Lantern";
	heros[4] = "Hawkman";
	heros[5] = "Bat Girl";

	print (heros[0]);	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

//EXAMPLE 2//
public class Arrays2 : MonoBehaviour {

	public string[] brownEggs = new string[12];

	
	// Use this for initialization
	void Start () {
	brownEggs[0] = "Good";
	brownEggs[1] = "Good";
	brownEggs[2] = "Good";	
	brownEggs[3] = "Bad";
	brownEggs[4] = "Good";
	brownEggs[5] = "Good";
	brownEggs[6] = "Good";
	brownEggs[7] = "Good";
	brownEggs[8] = "Good";
	brownEggs[9] = "Good";
	brownEggs[10] = "Good";
	brownEggs[11] = "Good";
	}
}

//EXAMPLE 3//
// public class Arrays3 : MonoBehaviour {

// 	public GameObject[] inventory = new GameObject[4];

	
// 	// Use this for initialization
// 	void Start () {
// 	inventory[0] = "Bazooka";
// 	inventory[1] = "M-16";
// 	inventory[2] = "Shotgun";	
// 	inventory[3] = "Pistol";
	
// 	}
// }

//EXAMPLE 4//
// public class Arrays4 : MonoBehaviour {

// 	public int[] money = new int[6];

	
// 	// Use this for initialization
// 	void Start () {
// 	money[0] = "36";
// 	money[1] = "40";
// 	money[2] = "100";	
// 	money[3] = "60";
// 	money[4] = "25";
// 	money[5] = "12";
	
// 	}
// }

//EXAMPLE 5//
public class Arrays5 : MonoBehaviour {

	public string[] grocery = new string[6];

	
	// Use this for initialization
	void Start () {
	grocery[0] = "Bread";
	grocery[1] = "Salad";
	grocery[2] = "Watermelon";	
	grocery[3] = "Stake";
	grocery[4] = "Pepers";
	grocery[5] = "Homey";
	
	}
}

//EXAMPLE 6//
public class Arrays6 : MonoBehaviour {

	public string[] clothing = new string[6];

	
	// Use this for initialization
	void Start () {
	clothing[0] = "Shirt";
	clothing[1] = "Pants";
	clothing[2] = "Shoes";	
	clothing[3] = "Socks";
	clothing[4] = "Underschirt";
	clothing[5] = "PJs";
	
	}
}

//EXAMPLE 7//
public class Arrays7 : MonoBehaviour {

	public string[] launderyMat = new string[6];

	
	// Use this for initialization
	void Start () {
	launderyMat[0] = "Blacks";
	launderyMat[1] = "Whites";
	launderyMat[2] = "Delicates";	
	launderyMat[3] = "Towls";
	launderyMat[4] = "Sheets";
	launderyMat[5] = "WhetKitchenRags";
	
	}
}

//EXAMPLE 8//
public class Arrays8 : MonoBehaviour {

	public string[] dryer = new string[5];

	
	// Use this for initialization
	void Start () {
	dryer[0] = "Blacks";
	dryer[1] = "Whites";
	dryer[2] = "WhetKitchenRags";	
	dryer[3] = "Towls";
	dryer[4] = "Sheets";
		
	}
}

//EXAMPLE 9//
public class Arrays9 : MonoBehaviour {

	public string[] lifeNeeds = new string[4];

	
	// Use this for initialization
	void Start () {
	lifeNeeds[0] = "Sleep";
	lifeNeeds[1] = "Food";
	lifeNeeds[2] = "Love";	
	lifeNeeds[3] = "PhisicaExercise";
	
		
	}
}

//EXAMPLE 10//
public class Arrays10 : MonoBehaviour {

	public GameObject[] marioGame = new GameObject[4];

	
	// Use this for initialization
	// void Start () {
	// marioGame[0] = "FindThePrincess";
	// marioGame[1] = "SurviveTheLevels";
	// marioGame[2] = "BeatTheBoss";	
	// marioGame[3] = "SaveThePrincess";
	
	// }
}