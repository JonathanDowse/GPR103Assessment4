using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    public AudioClip bump, select;                                              // assigning public audioclips so they can have audio files assigned to them within unity                                                            
    private AudioSource audioSource;                                            // creating an AudioSource variable called "audioSource"

    void Start()
    {
        audioSource = GetComponent<AudioSource>();                              // assigning the "audioSource" variable to the attached Audio Source component
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))                                        // if the player presses the "W" key...                                     
        {
            if (transform.position.y == -0.25)                                  // if the gameobject's Y position equals -0.25...
            {
                transform.position = new Vector3(0.09f, -1.75f, 0f);            // alter the gameobject's transform position to the button below
            }

            else if (transform.position.y == -1.75)                             // otherwuse if Y position equals -1.75...
            {
                 transform.position = new Vector3(0.09f, -3.25f, 0f);           // alter the gameobject's transform position to the button below
            }

            else if (transform.position.y == -3.25)                             // otherwise if Y position equals -3.25...
            {
                BumpSFX();                                                      // call function
            }
        }

        if (Input.GetKeyDown(KeyCode.W))                                        // if the player presses the "W" key...                              
        {
            if (transform.position.y == -3.25)                                  // if the gameobject's Y position equals -3.25...
            {
                transform.position = new Vector3(0.09f, -1.75f, 0f);            // alter the gameobject's transform position to the button above
            }

            else if (transform.position.y == -1.75)                             // otherwise if Y position equals -1.75...
            {
                transform.position = new Vector3(0.09f, -0.25f, 0f);            // alter the gameobject's transform position to the button above
            }

            else if (transform.position.y == -0.25)                             // otherwise if Y position equals -0.25...
            {
                BumpSFX();                                                      // call function
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))                                   // if player presses "Return" key...
        {
            if (transform.position.y == -3.25)                                  // if gameobject's Y position equals -3.25...
            {
                SelectSFX();                                                    // call function..
                Application.Quit();                                             // end the whole application/close program
            }

            else if (transform.position.y == -1.75)                             // if gameobject's Y position equals -1.75...
            {
                SelectSFX();                                                    // call function...
                SceneManager.LoadScene("Options");                              // load the project's "Options" scene
            }

            else if (transform.position.y == -0.25)                             // if gameobject's Y position equals -0.25...
            {
                SelectSFX();                                                    // call function...
                SceneManager.LoadScene("Game");                                 // load the project's "Game" scene
            }
        }
    }

    void BumpSFX()                                                              // called function
    {
        audioSource.Stop();                                                     // Stops audio component from playing...                                                                                   
        audioSource.clip = bump;                                                // assigns "select" audio file to audiosource's "clip" component...                                                                                
        audioSource.Play();                                                     // play assigned audiosource clip
    }

    void SelectSFX()                                                            // called function
    {
        audioSource.Stop();                                                     // Stops audio component from playing...
        audioSource.clip = select;                                              // assigns "select" audio file to audiosource's "clip" component...
        audioSource.Play();                                                     // play assigned audiosource clip

        for (int i = 0; i < 10; i++)                                            // for loop to create the slightest delay so player can hear the menu selection sound effect
        {

        }
    }

}
