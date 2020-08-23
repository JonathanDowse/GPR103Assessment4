using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
	private float spawnGap = .5f;														// a constant float value for equation that calculates time intervals between car spawns
	public GameObject[] car;															// creates array to put the vehilce prefabs in
	public Transform[] spawnPoints;														// creates array to put the car's spawn points in
	float nextTimeToSpawn = 0f;															// declaring a float whos value will constantly be altered as the equations output

	void Update()
	{
		if (nextTimeToSpawn <= Time.time)												// if nextTimeToSpawn is less/equal to Time.time (which will always be true) (Time.time increments value constantly since called/activated)																	
		{		
			SpawnCar();																	// calls function for spawning cars
			nextTimeToSpawn = Time.time + spawnGap;										// changing value to maintain car spawning
		}
	}

	void SpawnCar()																		// function for spawning cars
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);							// assigning value using the number of spawn points active and selecting spawn points at random
		Transform spawnPoint = spawnPoints[randomIndex];								// assigning transform position as one of the randomly selected points
		int carSelection = Random.Range(0, 3);											// assigning value to int variable to allow randomised car spawning
		Instantiate(car[carSelection], spawnPoint.position, spawnPoint.rotation);		// creating car instances with given values
	}
}

 