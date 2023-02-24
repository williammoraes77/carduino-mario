using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{

    // public Text points;
    // public Text firstName;

    public int totalMashrooms;
    public int lapsAmount;

    public int recordsPointsAmount;
    public int secondPointsAmount;
    public int thirdPointsAmount;
    public string recordsPointsName;
    public string secondPointsName;
    public string thirdPointsName;

    public string playerAtual;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }  

    // private void Start(){
    //      points.text = recordsPointsAmount.ToString();
    // }

}
