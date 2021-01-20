using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCount : MonoBehaviour
{    
    void OnTriggerEnter(Collider obj){
        if (obj.gameObject.tag == "Player"){

            CarVars player = obj.gameObject.GetComponent<CarVars>();

            switch (gameObject.tag){
                case "goal":
                    if(player.marker == 2)
                    {
                        player.marker = 0;
                        player.lap++;
                        
                        if(player.lap == player.totalLaps)
                        {
                            //CALCULAR PUNTUACIÓN DEL TIEMPO
                            if(player.getTime() < 90*player.totalLaps)
                            {
                                player.score += 90*player.totalLaps - (int)player.getTime();
                            }
                            //IR A ESCENA PUNTUACIÓN
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
