using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator60 : MonoBehaviour {
		public float speedRotate;
    private float angle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate (new Vector3 (0, 0, speedRotate) * Time.deltaTime * 2);
        this.angle += Time.deltaTime * this.speedRotate;
        float a = Mathf.Sin(angle) * 60;
        this.transform.localEulerAngles = new Vector3(0, 0, a);
	}
}
