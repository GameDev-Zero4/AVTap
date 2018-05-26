using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {
	public static WhenTouch touch;
    public float bounceForce;
	public GameObject bubble;
    private Rigidbody2D myBody;
    int score;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip flyClip, diedClip;


    void Awake()
    {
        
        myBody = GetComponent<Rigidbody2D>();
       
		touch = new WhenTouch ();
      

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
			if (touch.getTouch())
            {
                audioSource.PlayOneShot(flyClip);
                myBody.velocity = new Vector2(myBody.velocity.x, bounceForce);
				touch.setTouch ();
			}
        }
        else
        {
			bubble.SetActive (true);
            myBody.gravityScale = -3;
			if (touch.getTouch())
            {
                audioSource.PlayOneShot(flyClip);
                myBody.velocity = new Vector2(myBody.velocity.x, -bounceForce);
				touch.setTouch ();
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
           
            audioSource.PlayOneShot(diedClip);

            GamePlayController.instance.PlayDied(score);    
          //  Destroy(gameObject);
        }
       
    }
    




}
