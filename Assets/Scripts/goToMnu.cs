using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goToMnu : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject text;
    void Start()
    {
        text.GetComponent<Text>().text = "Tu puntuación fue de : "+ PlayerPrefs.GetInt("score")+" puntos";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToMenu(){
        SceneManager.LoadScene("menu");
    }
}
