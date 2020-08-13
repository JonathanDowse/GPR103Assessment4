using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject playerFrog;
	Vector2 frogPos;
	
	// Update is called once per frame
	void Update () {
		frogPos = Vector2.Lerp (gameObject.transform.position, playerFrog.transform.position, Time.deltaTime);
		gameObject.transform.position = new Vector2 (frogPos.x, 1);
	}
}
