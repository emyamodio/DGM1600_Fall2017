using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {

	public int valueOne;

	public int valueTwo;

	private int result;

		
	// Use this for initialization
	void Start () {
		DoMath();
		DoMath2();
		DoMath3();
		DoMath4();
	}
	
	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + " = " + result);
	}

	void DoMath2 (){
		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result);
	}

	void DoMath3 (){
		result = valueOne * valueTwo;
		print(valueOne + " * " + valueTwo + " = " + result);
	}

	void DoMath4 (){
		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result);
	}

	}
	// Update is called once per frame
	//void Update () {
		
	//}

