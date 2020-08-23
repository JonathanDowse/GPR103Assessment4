using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public Sprite death;                                        // creating a public sprite which allows designation within unity 

    void Update()
    {
        if (PlayerPrefs.GetInt("dead") == 1)                    // checking if saved PlayerPref int is = 1, value is set to 1 in other script when player dies then resets to 0 when form is restarted/re-opened
        {
            GetComponent<SpriteRenderer>().sprite = death;      // assigning a sprite to the already active yet empty sprite renderer so that it now has an image to display
        }
    }
}
