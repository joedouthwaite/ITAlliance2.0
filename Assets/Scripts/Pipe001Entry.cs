using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Entry : MonoBehaviour {

	public GameObject PipeEntry;
	public GameObject MainCam;
	public GameObject SecondCam;
	public GameObject MainPlayer;
	public GameObject player;
	public GameObject fadeScreen;
	public AudioSource pipeSound;
	public int StoodOn;


	public void OnTriggerEnter(Collider col) // If the game Object is stood in, it will change the value of StoodOn to = 1;
	{
		StoodOn = 1;
	}

	public void OnTriggerExit(Collider col)  //If the char is not in the game objext , it will change the value of StoodOn to = 0. It's used to track this.
	{
		StoodOn = 0;
	}





	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("ThirdPersonController");
	}
	
	public void Update()
	{
		if (Input.GetButtonDown("GoDown")) // Maps to the Keyboard's Down Key or S Key so when the Down key is pressed and  when the StoodOn value is = 1, and so it will only happen when the char is colliding with the game object.
		{
			if(StoodOn == 1)
			{               
				
				this.transform.position = new Vector3(0, -1000, 0);   // Change the postion of the game object if the StoodOn value = 1, using a vector.           
				StartCoroutine(WaitingForPipe());    //Calls The WaitingForPipe Animantion Function. It can only be called when the StoodOn value = 1 and the player is pressing the Down Key or alt 'S' key.'           

			}

		}    
	}


	IEnumerator WaitingForPipe() // Performs the PipeEntry Animantion 
	{
		pipeSound.Play (); // Play the PipeEntry Sound, when the animantion starts!
		fadeScreen.SetActive (true); 
		player.SetActive(false);  // When the player is in the pipe, it disables the character so the player can not move and mess up anything.
		PipeEntry.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds(1.5f); // It waits for 1.5 seconds same as the fadescreen anim, then stops the animation. 
		fadeScreen.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds (0.495f); //Stop the anim for almost half a second.
		fadeScreen.GetComponent<Animator>().enabled = false;
		PipeEntry.GetComponent<Animator>().enabled = false; // When the Animation is done, it turns it off. Acts as a pause in the animantion too.
		SecondCam.SetActive(true); // Enables the Second Camera for the second section
		MainCam.SetActive(false); // When the player enters the second section, it disables the first camera (MainCam) 
		MainPlayer.transform.position = new Vector3(12.942F, -6.76F, -0.3199F); // Moves the player to the start of the new second section and a postion where he's falling, according to these vector components, xyz coordinates. 
		// I got the coordinates, by duplicating a cube at a point at the start and getting the postion vector components from it. 
		player.SetActive(true);  // When the Animation function is done, it renables the character so the player can contiune.
		fadeScreen.GetComponent<Animator>().enabled = true;
		yield return new WaitForSeconds (0.495f); 
		fadeScreen.GetComponent<Animator>().enabled = false; // Turning the anim off.
		fadeScreen.SetActive (false); //Disable the fade screen object.
		StoodOn = 0;  // Set the value back to 0, so the telport animation doesn't keep playing, when the player preses the down key when he's already in the new section.

	}
}﻿