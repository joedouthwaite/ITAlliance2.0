using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalLives : MonoBehaviour {

	public static int livesAmount = 3; // The player starts off with 3 lives.
	public int internalLives; 
	public GameObject lifeTextBox;


	// Use this for initialization
	void Start () {
		
	}

	public IEnumerator GameOver()
	{
		yield return new WaitForSeconds (2.9f);
		SceneManager.LoadScene (2); // Game Over Scene
	}
	
	// Update is called once per frame
	void Update () {
		internalLives = livesAmount;
		lifeTextBox.GetComponent<Text>().text = "" + internalLives; // Updates the "Lives" text 

		if (internalLives == 0) 
		{
			GameOver();
		}

	}


}
