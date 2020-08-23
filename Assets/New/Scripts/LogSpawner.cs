using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
	public float minGap = 3f;															// declaring and assigning value to a new float variable
	public float maxGap = 5f;                                                           // declaring and assigning value to a new float variable
	private float spawnGap;																// declaring a float value for time intervals between logs
	public GameObject[] log;                                                            // declaring a public gameobject array that allows log prefabs to be assigned to it within unity
	public Transform[] spawnPoints;                                                     // declaring a public transform array that allows log spawanpoints to be assigned to it for their transform positions within unity
	float nextTimeToSpawn = 0f;                                                         // declaring a float whos value will constantly be altered as the equations output

	void Update()
	{
		if (nextTimeToSpawn <= Time.time)                                               // if nextTimeToSpawn is less/equal to Time.time (which will always be true) (Time.time increments value constantly since called/activated)	
		{
			SpawnLog();                                                                 // calls function for spawning logs
			spawnGap = Random.Range(minGap, maxGap);									// assinging a random value to "spawnGap" using the already declared "minGap" and "maxGap"
			nextTimeToSpawn = Time.time + spawnGap;                                     // changing value to maintain log spawning
		}
	}

	void SpawnLog()                                                                     // called function for spawning logs
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);                          // assigning value using the number of spawn points active and selecting spawn points at random
		Transform spawnPoint = spawnPoints[randomIndex];                                // assigning transform position as one of the randomly selected points
		int logSelection = Random.Range(0, 3);                                          // assigning value to int variable to allow randomised log spawning
		Instantiate(log[logSelection], spawnPoint.position, spawnPoint.rotation);       // creating log instances with given values
	}
}
