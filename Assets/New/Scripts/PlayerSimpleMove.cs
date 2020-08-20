using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;

public class PlayerSimpleMove : MonoBehaviour
{

    public Sprite up, down, left, right, drowned, drowned2, hit;            // allows sprite allocation for different conditons 
    public AudioClip hop, roadKill, begin, item, drown;    // declaring audio clip variables to assign files to
    private AudioSource audioSource;               // declaring audio source component
    public bool playerAlive = true;                 // assigning player alive condition
    public float camBase;                           // assigning an empty value for the bottom of the screen based on the camera view
    public bool onLog = false;
    public bool inWater = false;
    public float logDir = 0f;
    public float waterDeathCheck = 0f;
    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        camBase = Camera.main.transform.position.y - 5.5f;                                                              // assigning bottom of screen for camera movement and player boundaries 


        


        

        if (Input.GetKeyDown(KeyCode.W) && playerAlive == true)                                                         // move forward
        {
            transform.position = transform.position + new Vector3(0, 1, 0);
            GetComponent<SpriteRenderer>().sprite = up;                                                                 // changing sprite to directional sprite
            PlayJumpSound();

        }

        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y >= camBase + 1.0f && playerAlive == true)          // move backward
        {
            transform.position = transform.position + new Vector3(0, -1, 0);
            GetComponent<SpriteRenderer>().sprite = down;                                                               // ^^
            PlayJumpSound();
        }

        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -7 && playerAlive == true)                       // move left
        {
            transform.position = transform.position + new Vector3(-1, 0, 0);
            GetComponent<SpriteRenderer>().sprite = left;                                                               // ^^
            PlayJumpSound();
        }

        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 7 && playerAlive == true)                        // move right
        {
            transform.position = transform.position + new Vector3(1, 0, 0);
            GetComponent<SpriteRenderer>().sprite = right;                                                              // ^^
            PlayJumpSound();
        }

        else if (Input.GetKeyDown(KeyCode.R) && playerAlive == false)                                                   // if player is killed, R can be pressed to restart
        {
            

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);                                                 // code resets game scene
        }

        if(transform.position.x >= 8.1 || transform.position.x <= -8.1)
        {
            playerAlive = false;
        }


        if (onLog == false && inWater == true && playerAlive == true)
        {
            PlayerDrowned();
            playerAlive = false;
            tag = "Dead";
            GetComponent<SpriteRenderer>().sortingOrder = 1;
            DrownFrame0();
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.tag == "ActiveLogR")
            {
                logDir = -2f;
                onLog = true;
            }

        if (collision.tag == "ActiveLogL")
        {
            logDir = 2;
            onLog = true;
        }




        if (collision.tag == "Drown")
        {
            inWater = true;
        }
        


        if (collision.tag == "Mobile" && playerAlive == true)                                                           // if player collides with any gameobjects with the "Mobile" tag and player isnt declared dead yet
        {
            PlayRoadKillSound();                                                                                        // calls another function
            playerAlive = false;                                                                                        // player is killed
            Debug.Log("Dead");    
        } 

        
    }

    private void FixedUpdate()
    {

            transform.Translate(Vector2.right * Time.deltaTime * logDir, Space.World);

       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Drown")
        {
            inWater = false;
        }

        if (collision.tag == "Log")
        {
            logDir = 0f;
            onLog = false;

        }
    }

    void PlayerDrowned()
    {
        
        PlayRoadKillSound();
    }


    void PlayJumpSound()
    {
        audioSource.Stop();                                                                                            // Stops audio component from playing
        audioSource.clip = hop;                                                                                        // assigns new audio file to component
        audioSource.Play();                                                                                            // plays component file
    }

    void PlayRoadKillSound()
    {
        audioSource.Stop();                                                                                            // Stops audio component from playing
        audioSource.clip = roadKill;                                                                                   // assigns new audio file to component
        audioSource.Play();                                                                                            // plays component file
    }


    void DrownFrame0()
    {
        this.GetComponent<SpriteRenderer>().sprite = drowned;    // assigning assigned sprite variable to gameobject's active sprite
        Invoke("DrownFrame1", 0.4f);                           // ^^
    }

    void DrownFrame1()
    {
        this.GetComponent<SpriteRenderer>().sprite = drowned2;    
        Invoke("DrownFrame0", 0.4f);                           
    }




}
