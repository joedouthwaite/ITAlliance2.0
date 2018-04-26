using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverToFirstLevel : MonoBehaviour {

	public AudioSource evilLaugh;

	public IEnumerator Start()
	{
		evilLaugh.Play ();
		yield return new WaitForSeconds (4);
		GlobalLives.livesAmount += 3; // Add the Lives back on.
		SceneManager.LoadScene(0); // Takes you back to the the Level001 preload, we'll change this to the main menu when it's implmented.
	}



}
