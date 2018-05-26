using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

    public float bounceForce;
	public GameObject bubble;
    private Rigidbody2D myBody;
    int score;

    void Awake()
    {
        
        myBody = GetComponent<Rigidbody2D>();
       
      
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
	}

    void Move()
    {
        if (transform.position.y > 0)
        {
			bubble.SetActive (false);
            myBody.gravityScale = 3;
			if (Input.GetKey(KeyCode.Space))
            {
                myBody.velocity = new Vector2(myBody.velocity.x, bounceForce);
            }
        }
        else
        {
			bubble.SetActive (true);
            myBody.gravityScale = -3;
			if (Input.GetKey(KeyCode.Space))
            {
                myBody.velocity = new Vector2(myBody.velocity.x, -bounceForce);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "GameScore")
        {
           
            score++;
            if (GamePlayController.instance != null)
            {
                GamePlayController.instance._SetScore(score);
            }
          
        }
      else {
            GamePlayController.instance.PlayDied(score);    
            Destroy(gameObject);
        }
    }
    




}
