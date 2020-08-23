using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public Transform levelSpawn;                                                                // creating a public transform that can have a gameobject's position assigned to it within unity
    public GameObject[] terrain;                                                                // declaring an array that can host all the terrain variations and prefabs through unity
    public float initialY;                                                                      // declaring a float for later use and assignment
    public float currentY;                                                                      // declaring a float for later use and assignment

    void Start()
    {
        initialY = -5f;                                                                         // assigning "initialY" to -5 to simulate the player's starting Y position for later calculations
    }

    void Update()
    {
        currentY = GameObject.Find("Frog").transform.position.y;                                // searching for "Frog" gameobject and constantly assigning its y position to the "currentY" float... 

        if (currentY == initialY + 2)                                                           // if "currentY" equals "initialY" + 2, used to simulate the player's movement while accounting for backwards movements               
        {
            GenerateLevel();                                                                    // calling another function within this script
        }
    }

    void GenerateLevel()                                                                        // called function
    {
        initialY = currentY;                                                                    // setting "initialY" to the "currentY" value so the process withing the update function and repeat under the same logic
        int levelSelection = Random.Range(0, 3);                                                // declaring an int and assigning it a random value...
        Instantiate(terrain[levelSelection], levelSpawn.position, levelSpawn.rotation);         // creating a new clone/instance of a randomly selected prefab to keep the level generating
        
    }
}
