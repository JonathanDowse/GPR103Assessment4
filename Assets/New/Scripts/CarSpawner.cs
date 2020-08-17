using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
	private float spawnGap = .5f;														// float value for time intervals between cars
	public GameObject[] car;															// creates array to put the vehilce prefabs in
	public Transform[] spawnPoints;														// creates array to put spawn points in
	float nextTimeToSpawn = 0f;															// assigning value 

	void Update()
	{
		if (nextTimeToSpawn <= Time.time)																			
		{		
			SpawnCar();																	// calls function for spawning cars
			nextTimeToSpawn = Time.time + spawnGap;										// changing value to maintain car spawning
		}
	}

	void SpawnCar()																		// function for spawning cars
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);							// assigning value using the number of spawn points active and selecting spawn points at random
		Transform spawnPoint = spawnPoints[randomIndex];								// assigning calculated value
		int carSelection = Random.Range(0, 3);											// selecting random car prefab from given list
		Instantiate(car[carSelection], spawnPoint.position, spawnPoint.rotation);		// creating car instances with given values
	}
}

