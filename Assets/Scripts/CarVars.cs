using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarVars : MonoBehaviour
{
    public GameObject timer;
    public int lap;
    public int totalLaps;
    public int marker;
    public int score;
    public float getTime(){
        return timer.GetComponent<Timer>().time;
    }
    
    void Start()
    {
        score = 0;
        lap = 0;
        marker = 0;
        totalLaps = PlayerPrefs.GetInt("laps",3);
    }
}
