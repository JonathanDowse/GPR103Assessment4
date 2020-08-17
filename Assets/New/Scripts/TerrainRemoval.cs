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
    }
}
