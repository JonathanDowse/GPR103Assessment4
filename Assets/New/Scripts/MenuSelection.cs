using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelection : MonoBehaviour
{
    
    public AudioClip bump, select;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))                                                        // move forward
        {
            if (transform.position.y == -0.25)
            {
                transform.position = new Vector3(0.09f, -1.75f, 0f);
            }

            else if (transform.position.y == -1.75)
            {
                 transform.position = new Vector3(0.09f, -3.25f, 0f);
            }

            else if (transform.position.y == -3.25)
            {
                BumpSFX();
            }
        }


        if (Input.GetKeyDown(KeyCode.W))                                                        // move forward
        {
            if (transform.position.y == -3.25)
            {
                transform.position = new Vector3(0.09f, -1.75f, 0f);
            }

            else if (transform.position.y == -1.75)
            {
                transform.position = new Vector3(0.09f, -0.25f, 0f);
            }

            else if (transform.position.y == -0.25)
            {
                BumpSFX();
            }
        }


        if (Input.GetKeyDown(KeyCode.Return))                                                        // move forward
        {
            if (transform.position.y == -3.25)
            {
                SelectSFX();
                Application.Quit();
            }

            else if (transform.position.y == -1.75)
            {
                SelectSFX();
                SceneManager.LoadScene("Options");
            }

            else if (transform.position.y == -0.25)
            {
                SelectSFX();
                SceneManager.LoadScene("Game");
            }
        }
    }

    void BumpSFX()
    {
        audioSource.Stop();                                                                                            // Stops audio component from playing
        audioSource.clip = bump;                                                                                   // assigns new audio file to component
        audioSource.Play();
    }

    void SelectSFX()
    {
        audioSource.Stop();                                                                                            // Stops audio component from playing
        audioSource.clip = select;                                                                                   // assigns new audio file to component
        audioSource.Play();

        for (int i = 0; i < 2; i++)
        {

        }
    }

}
