using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour {
	public float bounceForce;
	private Rigidbody2D myBody;
	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < 3) {
			myBody.gravityScale = -3;
			myBody.velocity = new Vector2 (myBody.velocity.x,bounceForce);
		} else {
			myBody.gravityScale = 3;
			myBody.velocity = new Vector2(myBody.velocity.x,- bounceForce);
		}
		}
	}

