using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject botonOpciones;
    [SerializeField] GameObject botonJugar;
    [SerializeField] GameObject menuOpciones;
    void Start()
    {
        
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
        menuOpciones.SetActive(true);
    }

    public void hideOptions(){

    }
}
