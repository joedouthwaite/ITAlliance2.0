using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RubyToQuiz : MonoBehaviour {

	public GameObject player;
	public GameObject fadeScreen;
	public AudioSource victorySound;



	public IEnumerator OnTriggerEnter(Collider col) 
	{
		player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().enabled = false; // Disables the player input
		player.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = false;
		victorySound.Play ();
		yield return new WaitForSeconds (3);
		fadeScreen.SetActive (true); 
		yield return new WaitForSeconds(1.5f); // It waits for 1.5 seconds same as the fadescreen anim, then stops the animation. 
		fadeScreen.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds (0.495f); //Stop the anim for almost half a second.
		fadeScreen.GetComponent<Animator>().enabled = false;
		fadeScreen.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds (0.495f); 
		fadeScreen.GetComponent<Animator>().enabled = false; // Turning the anim off.
		fadeScreen.SetActive (false); //Disable the fade screen object.
		SceneManager.LoadScene (5); //Loads the quiz scene! 

	}



}
