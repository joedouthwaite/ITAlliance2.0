using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour {

	public Text coinDisplay;
	public static int coinCount; //  "Static" and "public"  So you can use and access it from an diffrent script.
	public int internalCoin;

	
	// Update is called once per frame
	void Update () { // Constaly update the number of coins collected 
		internalCoin = coinCount; // We use internalCoin to be able to determine the value of coinCount in Unity, if we need to, testing etc.
		coinDisplay.GetComponent<Text> ().text = "Coins: " + coinCount; //The Text and add it to the coinCount variable.
	}
}
