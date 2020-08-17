using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
	public Rigidbody2D rb;                                                          // creating a rigidbody to assign the parent component to
	public float minSpeed = 4f;														// minimum speed value
	public float maxSpeed = 7f;														// maximum speed value
	float speed;																	// declaring a speed variable

	void Start()
	{
		speed = Random.Range(minSpeed, maxSpeed);									// assigning a random number to the speed variable
	}

	void FixedUpdate()
	{
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);		// assigning gameobject's position to a new vector 
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);		// moving the car gameobjects forward at a random calculated speed
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CarDestroyer")											// if the car collides with any gameobject with the "CarDestroyer" tag							
        {
			Destroy(gameObject);													// destroy parent gameobject
        }
    }
}
