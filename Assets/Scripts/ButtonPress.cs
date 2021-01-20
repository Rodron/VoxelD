using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public bool pressed;

    public void press(){
        pressed = true;
    }
    public void unpress(){
        pressed = false;
    }
    void Start()
    {
        pressed = false;
    }

}
