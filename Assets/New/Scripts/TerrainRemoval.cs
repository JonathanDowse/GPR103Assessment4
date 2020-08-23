using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainRemoval : MonoBehaviour
{
    public Rigidbody2D rb;                                  // creating a rigidbody to assign the parent component to

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TerrainRemover")              // if component collides with a gameobject with the "TerrainRemover" tag
        {
            Destroy(gameObject);                            // destroy the parent component
        }                                   
    }                                                       // this script is attached to all environment prefabs and car/log prefabs too just to be safe. It ensures to delete all gameobjects such as level, logs, cars, etc. once...
}                                                           // they leave the view of the camera and collide with large gameobjects that trail the camera as it follows the player, minimising game lag etc.
