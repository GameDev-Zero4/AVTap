﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlColPlane : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Plane") {
			col.gameObject.SetActive (false);
			Destroy (col.gameObject);
		}
	}
}
