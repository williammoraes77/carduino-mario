using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    Controlador controlador;

    public Text InputName;
    // private string input;
    public static string name_user;
    public GameObject alert;

    public Text textMashrooms;

    private void Start()
    {
        name_user=null;
        controlador = FindObjectOfType<Controlador>();
    }

    public void UpdateMashrooms()
    {
        textMashrooms.text = "Cogumelos: " + controlador.totalMashrooms;
    }
    
    public void StartNivel(int id)
    {

        controlador.playerAtual = name_user;

        if(name_user != null){
          SceneManager.LoadScene(id);  
        }else {
            alert.SetActive(true);
        }
        
    }

    public void ReadInput(string name)
    {
        name_user = name.ToString();

    }


    public void GoRecords()
    {
        SceneManager.LoadScene(2);  
    }
}
