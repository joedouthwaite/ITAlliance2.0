using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverToLevel2 : MonoBehaviour {

	public AudioSource evilLaugh;
	public IEnumerator Start()
	{
		evilLaugh.Play ();
		yield return new WaitForSeconds (4);
		GlobalLives.livesAmount += 3; // Add the Lives back on.
		SceneManager.LoadScene(3); // Takes you back to the the Level02 preload.
	}

}
