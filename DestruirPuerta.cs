using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPuerta : MonoBehaviour {
	 bool door_open = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void destruyePuerta()
    {	
		if(!door_open) {
			 this.transform.Rotate(0, -90, 0);
			 door_open = true;
		}
		else {
			this.transform.Rotate(0, +90, 0);
			door_open = false;
		}
		
    }
}
