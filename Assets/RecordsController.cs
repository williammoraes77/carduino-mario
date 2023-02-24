using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecordsController : MonoBehaviour
{
    Controlador controlador;

    public Text RecordsPoints;
    public Text RecordsName;
    public Text SecondPoints;
    public Text SecondName;
    public Text ThirdPoints;
    public Text ThirdName;

    private void Awake()
    {
         controlador = FindObjectOfType<Controlador>();
        
    }


    public void Start()
    {
        Debug.Log(controlador.recordsPointsName);
        RecordsPoints.text = controlador.recordsPointsAmount.ToString();
        RecordsName.text = controlador.recordsPointsName;
        SecondPoints.text = controlador.secondPointsAmount.ToString();
        SecondName.text = controlador.secondPointsName;
        ThirdPoints.text = controlador.thirdPointsAmount.ToString();
        ThirdName.text = controlador.thirdPointsName;
    }

     public void GoBack()
    {

        SceneManager.LoadScene(0);
    }


}
