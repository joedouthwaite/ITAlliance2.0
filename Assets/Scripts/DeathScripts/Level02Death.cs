using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02Death : MonoBehaviour {

	public AudioSource deathSound;
	public GameObject levelMusic; 
	public GameObject camFollow;
	public GameObject player;


	public IEnumerator OnTriggerEnter (Collider col)
	{
		levelMusic.SetActive (false);
		GlobalLives.livesAmount -= 1; // When the player dies, it will take a life away
		GlobalCoins.coinCount = 0; // When the player dies, it will reset the Coins amount back to 0.
		deathSound.Play ();
		camFollow.GetComponent<CameraFollow>().enabled = false; // Disables the CameraFollow script.
		player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().enabled = false; // Disables the player input
		player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = false;
		player.transform.localScale -= new Vector3 (0.0f, 1.0f, 0.0f);
		player.GetComponent<CapsuleCollider> ().enabled = false;
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene (3);  // Restarts the level from the preload scene with the black fade in. 

		if (GlobalLives.livesAmount == 0) 
		{
			SceneManager.LoadScene (6); // Game Over Screen for level2.
		}

	}














}

