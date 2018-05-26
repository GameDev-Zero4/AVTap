using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Creep : MonoBehaviour {

	public GameObject deadEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
			
		    
			deadEffect.SetActive (true);
        }
    }

}
