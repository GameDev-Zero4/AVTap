using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator60 : MonoBehaviour {
	public float speedRotate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while(transform.rotation.z<150)
			transform.Rotate(new Vector3(0,0,transform.rotation.z+speedRotate)*Time.deltaTime);
		while(transform.rotation.z>210)
			transform.Rotate(new Vector3(0,0,transform.rotation.z-speedRotate)*Time.deltaTime);
	}
}
