using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)                             // when a trigger collision occurs...
    {
        if (collision.tag == "Player" && this.tag == "ScoreAdder")                  // if player collides with any gameobjects with "ScoreAdder" as their tag...
        {
            this.tag = "Terrain";                                                   // gameobject player collides with changes tag to ensure it doesn't add to the score twice and so it can be destroyed by terrainremoval                                              
            GameObject.Find("Score").GetComponent<Score>().scoreAddition();         // searches for a gameobject "Score" then gets its attached "Score" script and calls the "scoreAddition" function
        }
    }
}
