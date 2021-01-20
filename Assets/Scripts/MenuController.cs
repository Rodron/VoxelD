using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject botonOpciones;
    [SerializeField] GameObject botonJugar;
    [SerializeField] GameObject menuOpciones;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject titulo;
    [SerializeField] Slider slider;
    [SerializeField] InputField numeroVueltas;



    int outLap = 3; 
    void Start()
    {   slider.value = PlayerPrefs.GetFloat("volume",1.0f);
        
        AudioListener.volume = slider.value;

        int outLap = PlayerPrefs.GetInt("laps",3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void showOptions(){
        botonOpciones.SetActive(false);
        botonJugar.SetActive(false);
        titulo.SetActive(false);
        menuOpciones.SetActive(true);
    }

    public void hideOptions(){

        PlayerPrefs.SetFloat("volume",slider.value);
        int.TryParse(numeroVueltas.text,out outLap);
        PlayerPrefs.SetInt("laps",outLap);    
        
        

        menuOpciones.SetActive(false);
        botonOpciones.SetActive(true);
        titulo.SetActive(true);
        botonJugar.SetActive(true);
    }

    public void changeVolume(){
        AudioListener.volume = slider.value;
    }

    
    
}
