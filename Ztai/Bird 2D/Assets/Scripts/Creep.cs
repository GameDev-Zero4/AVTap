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
			CameraShaker.Instance.ShakeOnce (4f, 4f, 1f, 1f);

			deadEffect.SetActive (true);
        }
    }

}
