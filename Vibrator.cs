﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CahngeColor()
    {
        Renderer rend = GetComponent<Renderer> ();
        rend.material.color = Color.red;
    }
}
