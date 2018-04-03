using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNonDestroy : MonoBehaviour {

	public float xPos;
		public float yPos;
		public float zPos;

		IEnumerator OnTriggerEnter (Collider col) // Col is the name of the collider 
		{
			transform.GetComponent<Collider> ().isTrigger = false; // Disables the trigger collider at first
			if(col.gameObject.tag == "Player") // Checks if the "Player" is colliding with the object.
			{
				this.transform.position = new Vector3 (xPos, yPos + 0.2F, zPos); //this keyword assings it to that object, and also move up the ypos when the player colldies with the object.
				yield return new WaitForSeconds (0.08F); // Yield means to stop the code for x amount, before it excutes the next line of code.
				this.transform.position = new Vector3 (xPos, yPos, zPos); //  Returns the object to the original Postion.
				yield return new WaitForSeconds(0.25F);
				transform.GetComponent<Collider>().isTrigger = true;
			}
		}

		// Use this for initialization
		void Start () {
			xPos = transform.position.x;
			yPos = transform.position.y;
			zPos = transform.position.z;


		}



		// Update is called once per frame
		void Update () {

		}
	}
