using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    /// <summary>
    /// -1 = left, 1 = right
    /// </summary>
    public int moveDirection = 1;
    public float speed = 1;
    public Vector2 startingPosition;
    public Vector2 endPosition;


    void Start()
    {
        transform.position = startingPosition;
    }

    void Update()
    {

        transform.Translate(Vector2.right * Time.deltaTime * speed * moveDirection);

        if ((transform.position.x * moveDirection) > (endPosition.x * moveDirection))
        {
            transform.position = startingPosition;
        }
    }

}
