using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreUpdater : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && this.tag == "ScoreAdder")                                                           // if player collides with any gameobjects with the "Mobile" tag and player isnt declared dead yet
        {
            this.tag = "Terrain";
            GameObject.Find("Score Tracker").GetComponent<Score>().scoreAddition();
            
        }
    }
}
