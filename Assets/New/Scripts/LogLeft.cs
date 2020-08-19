using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLeft : MonoBehaviour
{
    public Rigidbody2D rb;                                                          // creating a rigidbody to assign the parent component to

    public float speed = 2f;                                                                    // declaring a speed variable

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);        // assigning gameobject's position to a new vector 
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);       // moving the log gameobjects forward at a random calculated speed
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
                tag = "ActiveLogL";
        }
        if (collision.tag == "CarDestroyer")                                        // if the log collides with any gameobject with the "CarDestroyer" tag							
        {
            Destroy(gameObject);                                                    // destroy parent gameobject
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }


    
}
