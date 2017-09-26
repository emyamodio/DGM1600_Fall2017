using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string townCenter;


	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main": 
				print("Welcome to Main Street!");
			break;
			case "blacksmith":
				print("The blacksmith grumbles as you pick though the sword bin");
			break;
			case "bakery":
				print("Mmmmmmmmmmmm baked goods");
			break;
			case "morgue":
				print("Peeeeeeeeeeeeeeeeeeeeyew! Dead things yuck!");
			break;
			default:
				print("I don't know what you are talking about!");
				break;

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
