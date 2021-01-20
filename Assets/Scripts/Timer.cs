using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    [SerializeField]GameObject car;  
    Text timerText;
    float time = 0f;
    bool endCountdown = true;
    
    string FormatTime (float time)
    {
        int intTime = (int) time;
        int minutes = intTime / 60;
        int seconds = intTime % 60;
        int fraction = (int)(time * 1000);
        fraction = fraction % 1000;
        string timeText = string.Format ("{0:00}:{1:00}:{2:000}", minutes, seconds,fraction);
        return timeText;
    }
    void Countdown()
    {
        if(timerText.text == "GO!"){
            return;
        }
        if(time > 1)
        {            
            int aux = (int.Parse(timerText.text) - 1);
            if(aux != 0)
            {
                timerText.text = "" + aux;
            }
            else
            {
                timerText.text = "GO!";
                time = -2;
                return;
            }
            
            time = 0f;
        }
    }
    void Start()
    {
        timerText = gameObject.GetComponent<Text>(); 
    }    
    void Update()
    {
        time += Time.deltaTime;

        if(time>3)
        {            
            timerText.text = FormatTime (time-3);
            return;
        }
        else if(gameObject.tag == "countdown" && time > 0)
        {
            Countdown();
            return;
        }
        
        if (gameObject.tag == "countdown" && time > -1){
            car.GetComponent<ArcadeCar>().axles[0].isPowered = true;
            car.GetComponent<ArcadeCar>().axles[1].isPowered = true;
            gameObject.SetActive(false);
        }
    }
}
