using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel2Preload : MonoBehaviour {

	public IEnumerator Start()
	{
		yield return new WaitForSeconds (4);
		GlobalLives.livesAmount += 3; // Add the Lives back on.
		SceneManager.LoadScene(3); // Takes you back to the the Level002 preload.

}

}