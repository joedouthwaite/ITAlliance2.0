using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomManDeath : MonoBehaviour {
	public  GameObject MushroomMan;	
    public IEnumerator OnTriggerEnter(Collider col)
    {
		this.GetComponent<BoxCollider> ().enabled = false;
		MushroomMan.GetComponent<MushroomManMove> ().enabled = false;
		MushroomMan.transform.localScale = new Vector3(0.0f, 0.8f, 0.0f);
		MushroomMan.transform.localPosition = new Vector3(0.0f, 0.4f, 0.0f);
		yield return new  WaitForSeconds(1.0f);
		MushroomMan.transform.position =  new Vector3(0.0f, 0.0f, 0.0f);

    }

   
	// Use this for initialization
	void Start ()
        {
          
	    }

    // Update is called once per frame
    void Update () {
       
	}
}
