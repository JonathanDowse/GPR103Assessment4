using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
	public float minGap = 3f;
	public float maxGap = 5f;
	private float spawnGap;                                                       // float value for time intervals between logs
	public GameObject[] log;                                                            // creates array to put the log prefabs
	public Transform[] spawnPoints;                                                     // creates array to put spawn points in
	float nextTimeToSpawn = 0f;                                                         // assigning value 

	void Update()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnLog();                                                                 // calls function for spawning logs
			spawnGap = Random.Range(minGap, maxGap);
			nextTimeToSpawn = Time.time + spawnGap;                                     // changing value to maintain log spawning
		}
	}

	void SpawnLog()                                                                     // function for spawning logs
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);                          // assigning value using the number of spawn points active and selecting spawn points at random
		Transform spawnPoint = spawnPoints[randomIndex];                                // assigning calculated value
		int logSelection = Random.Range(0, 3);                                          // selecting random car prefab from given list
		Instantiate(log[logSelection], spawnPoint.position, spawnPoint.rotation);       // creating car instances with given values
	}
}
