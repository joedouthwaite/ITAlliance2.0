using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMushroomMoveLevel : MonoBehaviour 
{
	public float LeftPoint = -20.0f;
	public float RightPoint = 11.0f;
	public int Direction = 1;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update ()
	{
		transform.parent = null;
		if (Direction == 1) {
			transform.Translate (Vector3.right * 2 * Time.deltaTime, Space.World);
			Direction = 1;
		}

		if (this.transform.position.x > RightPoint) {
			Direction = 2;
		}

		if (Direction == 2) {
			transform.Translate (Vector3.right * -2 * Time.deltaTime, Space.World);
			Direction = 2;
		}

		if (this.transform.position.x < LeftPoint) {
			Direction = 1;
		}
	}

}
		

