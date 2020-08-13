using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSimpleMove : MonoBehaviour
{

    public bool playerAlive = true;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && playerAlive == true)
        {
            transform.position = transform.position + new Vector3(0, 12, 0);
        }

        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y >= -8 && playerAlive == true)
        {
            transform.position = transform.position + new Vector3(0, -12, 0);
        }

        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x >= -14 && playerAlive == true)
        {
            transform.position = transform.position + new Vector3(-12, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x <= 14 && playerAlive == true)
        {
            transform.position = transform.position + new Vector3(12, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.R) && playerAlive == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Mobile")
        {
            playerAlive = false;
            Debug.Log("Dead");
            
        }

    }
}
