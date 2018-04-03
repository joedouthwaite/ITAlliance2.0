using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour {



	public float xPos;
	public float yPos;
	public float zPos;
	float waiting = 0.02F;

	IEnumerator OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			// Animantion but with Programming, Once the player has touched the object, it will change the vector components  according to the values below. Which the code below moves the object.
			this.transform.position = new Vector3(xPos, yPos + 0.1F, zPos);
			yield return new WaitForSeconds(waiting); // It will wait before excuting the next line of code. 
			this.transform.position = new Vector3(xPos, yPos + 0.2F, zPos);
			yield return new WaitForSeconds(waiting); 
			transform.GetComponent<Collider>().isTrigger = false;
			this.transform.position = new Vector3(xPos, yPos + 0.3F, zPos + 0.5F);
			yield return new WaitForSeconds(waiting);
			this.transform.position = new Vector3(xPos, yPos + 0.4F, zPos + 1.0F);
			yield return new WaitForSeconds(waiting);
			this.transform.position = new Vector3(xPos, yPos - 0.1F, zPos + 1.5F);
			yield return new WaitForSeconds(waiting);
			this.transform.position = new Vector3(xPos, yPos - 0.6F, zPos + 2.0F);
			yield return new WaitForSeconds(waiting);
			this.transform.position = new Vector3(xPos, yPos - 1.6F, zPos + 2.0F);
			yield return new WaitForSeconds(waiting);
			this.transform.position = new Vector3(xPos, yPos - 2.6F, zPos + 2.0F);
			yield return new WaitForSeconds(waiting);
			this.transform.position = new Vector3(xPos, yPos - 4.0F, zPos + 2.0F);
			yield return new WaitForSeconds(0.25F);
			transform.GetComponent<Collider>().isTrigger = true;
			Destroy(gameObject); // Removes whatever the script is attached to. 
		}
	}

	// Use this for initialization
	void Start()
	{
		xPos = transform.position.x;
		yPos = transform.position.y;
		zPos = transform.position.z;
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
