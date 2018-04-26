using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomManMove : MonoBehaviour {

    public float leftPoint = 13.0f;
    public float rightPoint = 28.0f;
    public int direction = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            direction = 1;
        }

        if(this.transform.position.x > rightPoint)
        {
            direction = 2;
        }

        if (direction == 2)
        {
            transform.Translate(Vector3.left * 2 * Time.deltaTime, Space.World);
            direction = 2;
        }

        if (this.transform.position.x < leftPoint)
        {
            direction = 1;
        }
    }
}
