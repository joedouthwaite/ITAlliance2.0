using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinPickUp : MonoBehaviour {
    public AudioSource CoinSound;


    void OnTriggerEnter(Collider col) // When the player enters\touches it
	{
		transform.position =  new Vector3(0, -1000, 0); // It will do an anim, and move it way from the screen. 
        CoinSound.Play();
        GlobalCoins.coinCount += 1;
	}


	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
	}
}
