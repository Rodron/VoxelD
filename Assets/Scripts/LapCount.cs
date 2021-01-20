using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LapCount : MonoBehaviour
{
    public GameObject lapText;
    public GameObject pj;
    float time = 0f;    

    void Update(){
        if(time < 0){
            return;
        }
        time += Time.deltaTime;
        if(time>.5f){
            lapText.GetComponent<Text>().text = (pj.GetComponent<CarVars>().lap+1) + "/" + pj.GetComponent<CarVars>().totalLaps;
            time = -2f;
        }
    }
    void OnTriggerEnter(Collider obj){
        if (obj.gameObject.tag == "Player"){

            CarVars player = obj.gameObject.GetComponent<CarVars>();

            switch (gameObject.tag){
                case "goal":
                    if(player.marker == 2)
                    {
                        player.marker = 0;
                        player.lap++;
                        lapText.GetComponent<Text>().text = player.lap + "/" + player.totalLaps;

                        if(player.lap == player.totalLaps)
                        {
                            //CALCULAR PUNTUACIÓN DEL TIEMPO
                            if(player.getTime() < 90*player.totalLaps)
                            {
                                player.score += 110*player.totalLaps - (int)player.getTime();
                            }
                            //IR A ESCENA PUNTUACIÓN
                            PlayerPrefs.SetInt("score", player.score);
                            SceneManager.LoadScene("puntuaciones");
                        }

                        Debug.Log("Vuelta " + player.lap);
                    }
                    break;
                case "col01":
                    if(player.marker == 0)
                    {
                        player.marker++;                        
                    }
                    break;
                case "col02":
                    if(player.marker == 1)
                    {
                        player.marker++;                        
                    }
                    break;
            }
        }
    }
}
