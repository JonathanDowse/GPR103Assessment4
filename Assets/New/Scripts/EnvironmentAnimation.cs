using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnvironmentAnimation : MonoBehaviour
{
    public Sprite frame1;                                       // creating a variable that can have a sprite assigned to it
    public Sprite frame2;                                       // ^

    void Start()
    {
        Invoke("FrameSwitch0", 0.4f);                           // calling a function after a short delay
    }

    void FrameSwitch0()                                         
    {
        this.GetComponent<SpriteRenderer>().sprite = frame1;    // assigning assigned sprite variable to gameobject's active sprite
        Invoke("FrameSwitch1", 0.4f);                           // ^^
    }

    void FrameSwitch1()
    {
        this.GetComponent<SpriteRenderer>().sprite = frame2;    // ^^
        Invoke("FrameSwitch0", 0.4f);                           // ^^
    }
}
