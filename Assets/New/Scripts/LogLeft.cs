using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLeft : MonoBehaviour
{
    public Rigidbody2D rb;                                                              // creating a rigidbody to assign the parent component to
    public float speed = 2f;                                                            // declaring a speed variable

    public void Awake()
    {
        tag = "LogL";                                                                   // assign object's own tag to "LogL" before start
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);            // assigning the 'forward' vector 2 a meaning and positional transformation
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);           // moving the log gameobjects forward at a set calculated speed
    }
    
    private void OnTriggerEnter2D(Collider2D collision)                                 // on collision with trigger...
    {
        if (collision.tag == "CarDestroyer")                                            // if the log collides with any gameobject that holds the "CarDestroyer" tag...							
        {
            Destroy(gameObject);                                                        // destroy parent gameobject
        }   
    }
}
