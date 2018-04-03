using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 2, 0, Space.World); // Rotate the coin relative to the world coordinates, making sure it's rotating correctly. It rotate on the Y axis whatever this script is attached to, so that's why there's no variables.
	//The "2" determines how fast it rotate on the Y axis and so on.
	}
}
