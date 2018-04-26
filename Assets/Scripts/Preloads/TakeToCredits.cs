using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeToCredits : MonoBehaviour {

	public AudioSource victorySound;
	public GameObject player;

	public IEnumerator OnTriggerEnter (Collider col)
	{
		player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().enabled = false; // Disables the player input
		player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = false;
		victorySound.Play ();
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene(7); // Takes you to the the Credits!
	}
}
