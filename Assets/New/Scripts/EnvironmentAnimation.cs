using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnvironmentAnimation : MonoBehaviour
{
    public Sprite frame1;                                       // creating a variable that can have a sprite assigned to it within unity
    public Sprite frame2;                                       // creating a variable that can have a sprite assigned to it within unity

    void Start()
    {
        Invoke("FrameSwitch0", 0.4f);                           // calling a function after a short delay
    }

    void FrameSwitch0()                                         // called function...                    
    {
        this.GetComponent<SpriteRenderer>().sprite = frame1;    // assigning the attached gameobject's sprite to "frame1"...
        Invoke("FrameSwitch1", 0.4f);                           // calling a function after a short delay
    }

    void FrameSwitch1()                                         // called function...
    {
        this.GetComponent<SpriteRenderer>().sprite = frame2;    // assigning the attached gameobject's sprite to "frame2"...
        Invoke("FrameSwitch0", 0.4f);                           // calling a function after a short delay
    }
}
