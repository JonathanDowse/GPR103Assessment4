using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelectionOptions : MonoBehaviour
{
    public AudioClip bump, select, scoreDelete;                                                 // assigning public audioclips so they can have audio files assigned to them within unity 
    private AudioSource audioSource;                                                            // creating an AudioSource variable called "audioSource"
    private bool scoreDeleted = false;                                                          // declaring and assigning a bool variable called "scoreDeleted" to the false value

    void Start()
    {
        scoreDeleted = false;                                                                   // declaring "scoreDeleted" as false to ensure it is false on all startups
        audioSource = GetComponent<AudioSource>();                                              // assigning the "audioSource" variable to the attached Audio Source component
        if (PlayerPrefs.GetInt("highScore") == 0)                                               // if the "highScore" playerprefs is equal to 0...
        {
            scoreDeleted = true;                                                                // "scoreDeleted" equals true
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))                                                        // if the player presses the "S" key... 
        {
            if (transform.position.y == -0.25)                                                  // if gameobject's Y position equals -0.25...
            {
                transform.position = new Vector3(0.09f, -1.75f, 0f);                            // alter the gameobject's transform position to the button below
            }

            else if (transform.position.y == -1.75)                                             // otherwise if gameobject's Y position equals -1.75...
            {
                 transform.position = new Vector3(0.09f, -3.25f, 0f);                           // alter the gameobject's transform position to the button below
            }

            else if (transform.position.y == -3.25)                                             // otherwise if gameobject's Y position equals -3.25...
            {
                BumpSFX();                                                                      // call function
            }
        }

        if (Input.GetKeyDown(KeyCode.W))                                                        // if the player presses the "W" key... 
        {
            if (transform.position.y == -3.25)                                                  // if gameobject's Y position equals -3.25...
            {
                transform.position = new Vector3(0.09f, -1.75f, 0f);                            // alter the gameobject's transform position to the button above
            }

            else if (transform.position.y == -1.75)                                             // otherwise if gameobject'Y position equals -1.75...
            {
                transform.position = new Vector3(0.09f, -0.25f, 0f);                            // alter the gameobject's transform position to the button above
            }

            else if (transform.position.y == -0.25)                                             // otherwise if gameobject's Y position equals -0.25...
            {
                BumpSFX();                                                                      // call function
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))                                                   // if the player presses the "Return" key...                                                
        {
            if (transform.position.y == -3.25)                                                  // if gameobject's Y position equals -3.25...
            {
                SelectSFX();                                                                    // call function...
                SceneManager.LoadScene("Menu");                                                 // load the project's
            }

            else if (transform.position.y == -0.25)                                             // otherwise if gameobject's Y position equals -0.25...
            {
                BumpSFX();                                                                      // call function
            }

            else if(transform.position.y == -1.75 && PlayerPrefs.GetInt("highScore") > 0)       // otherwise if gameobject's Y position equals -1.75 and playerprefs "highScore" is greater than 0...
            {
                PlayerPrefs.SetInt("highScore", 0);                                             // set value of playerprefs "highScore" to 0...
                WipeScore();                                                                    // call function
            }

            else if(scoreDeleted == true || PlayerPrefs.GetInt("highScore") == 0)               // otherwise if "scoreDeleted" is true OR "highScore" playerprefs is equal to 0...
            {
                BumpSFX();                                                                      // call function
            }
        }
    }

    void BumpSFX()                                                                              // called function
    {
        audioSource.Stop();                                                                     // Stops audio component from playing...                                                                                        
        audioSource.clip = bump;                                                                // assigns "bump" audio file to audiosource's "select" component...                                                                               
        audioSource.Play();                                                                     // play assigned audiosource clip
    }

    void SelectSFX()                                                                            // called function
    {
        audioSource.Stop();                                                                     // Stops audio component from playing...                                                                                         
        audioSource.clip = select;                                                              // assigns "scoreDelete" audio file to audiosource's "select" component...                                                                             
        audioSource.Play();                                                                     // play assigned audiosource clip

        for (int i = 0; i < 2; i++)                                                             // for loop to create the slightest delay so player can hear the menu selection sound effect
        {

        }
    }

    void WipeScore()                                                                            // called function                                                   
    {
        audioSource.Stop();                                                                     // Stops audio component from playing...
        audioSource.clip = scoreDelete;                                                         // assigns "scoreDelete" audio file to audiosource's "clip" component...
        audioSource.Play();                                                                     // play assigned audiosource clip
        scoreDeleted = true;                                                                    // changing the value of the "scoreDeleted" variable so if player tries to delete highscore without one, it plays another audioclip
    }    

}
