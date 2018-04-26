using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCollect : MonoBehaviour {

	public AudioSource growSound;
	public GameObject thePlayer;

	public void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")  //If it matches the player, so it will only affect the main player's character
		{
		this.transform.position = new Vector3 (0, -1000.0f, 0); //Moves it off the screen
		growSound.Play();
		thePlayer.transform.localScale += new Vector3 (0.3f, 0.3f, 0.3f); // Scales up the player and adds it to the player's current componenets.
		}
	}

}
