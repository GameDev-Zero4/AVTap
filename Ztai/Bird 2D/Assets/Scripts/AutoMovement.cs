using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour {

	private Rigidbody2D myBody;
	public float speed;
	// Use this for initialization
	void Awake()
	{

		myBody = GetComponent<Rigidbody2D>();


	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myBody.velocity = new Vector2(-speed, myBody.velocity.y);


	}
}
