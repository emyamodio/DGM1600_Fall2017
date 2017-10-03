using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loor : MonoBehaviour {
	public int bottles = 100;
	// Use this for initialization
	void Start () {
	// 	while(bottles > 0){
	// 		print(bottles + " of orange crush on the wall");
	// 		// bottles = bottles --;
	// 	}

	// for(int bottles = 100; bottles > 0; bottles --){
	// 	print(bottles + " of orange chrush on the wall");
	
	for(; bottles > 0; bottles --){
		print(bottles + " of orange chrush on the wall");
	}
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}