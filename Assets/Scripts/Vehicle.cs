using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEditor;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    /// <summary>
    /// -1 = left, 1 = right
    /// </summary>
    public int moveDirection = -1;
    public float speed;

    // Start is called before the first frame update
    void Initialise(Vector3 position, float speed, float maxX = 21)
    {
        transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0);
        float posX = transform.position.x;

        if (posX > 21 || posX < -21)
        {
            gameObject.SetActive(false);
        }
    }

}
