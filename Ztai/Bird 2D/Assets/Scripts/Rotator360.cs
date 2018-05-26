using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator360 : MonoBehaviour {

	public float speedRotate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, speedRotate) * Time.deltaTime * 2);
	}
}
