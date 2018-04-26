using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block001 : MonoBehaviour {



	public GameObject QBlock;
	public GameObject DeadBlock;
	public GameObject Mushroom;

	public IEnumerator OnTriggerEnter(Collider col) 
	{
		QBlock.SetActive(false);
		DeadBlock.SetActive(true);
		yield return new WaitForSeconds (0.2f);
		Mushroom.SetActive(true);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
