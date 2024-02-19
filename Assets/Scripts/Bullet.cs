using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] float bulletSpeed = 20f;
    Rigidbody2D myRigidBody;
    PlayerMovement player;
    float xSpeed;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();    
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

    void Update()
    {
        myRigidBody.velocity = new Vector2 (xSpeed, 0f);
    }

    void  OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Enemy")
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
    }
    
     void OnCollisionEnter2D(Collision2D other) {
        
        Destroy(gameObject);

    }
}
