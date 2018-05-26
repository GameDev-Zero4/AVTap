using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {



    [SerializeField]
    private GameObject bullet;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.2f);

        Instantiate(bullet, transform.position, Quaternion.identity);
        StartCoroutine(Attack());
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {

            Destroy(target.gameObject);
        }
    }

}
