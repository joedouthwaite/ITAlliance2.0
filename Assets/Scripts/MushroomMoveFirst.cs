using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMoveFirst : MonoBehaviour {
    public GameObject actualMushroom;
    public GameObject thisMushroom;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.parent = null; // Unparents the object
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World); //space.world - works with the rest of the game's timing, time.deltaTime - last frame time
		CloseScript();
	}
	IEnumerator CloseScript()
{
    yield return new WaitForSeconds(0.5f);
    actualMushroom.SetActive(true);
	thisMushroom.SetActive(false);
}
}

