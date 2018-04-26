using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02_Load : MonoBehaviour {


	// Use this for initialization
	public IEnumerator Start () 
	{
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene (4); //Each Scene is assigned a number, in the build settings, this loads number 4 which is the the second level
	}
}
