using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public Transform levelSpawn;
    public GameObject[] terrain;
    public float initialY;
    public float currentY;

    // Start is called before the first frame update
    void Start()
    {
        initialY = -5f;
    }

    // Update is called once per frame
    void Update()
    {
        currentY = GameObject.Find("Frog").transform.position.y;

        if (currentY == initialY + 2)
        {
            GenerateLevel();
        }

        

        
       
    }

    void GenerateLevel()
    {
        initialY = currentY;
        
            int levelSelection = Random.Range(0, 3);                                          // selecting random car prefab from given list
            Instantiate(terrain[levelSelection], levelSpawn.position, levelSpawn.rotation);       // creating car instances with given values
        
    }
}
