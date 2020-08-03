using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public float speed;
    public float targetDistance;

    private Transform target;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Core").GetComponent<Transform>();
    }

    void Update()
    {
        //Movement();
        //if(Vector2.Distance(transform.position, target.position) < targetDistance)
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

   /* private void Movement()
    {
        rb.velocity = new Vector2(50*speed * Time.deltaTime, 50*-speed * Time.deltaTime);
    }*/
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Core" || col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Udaren");
        }
        if (col.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            Score.scoreValue += 5;
        }
    }
}
