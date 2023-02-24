using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FimCorrida : MonoBehaviour
{
    public GameObject painel;
    public int totalPontosRun;
    Controlador controlador;
    Carro2 carro2;

    public Text mashroom;
    public Text coins;
    public Text kill_npc;
    public Text points;
    public Text time;
    public Text block;
    public Text bowser;
    public Text mashroomPoints;
    public Text timePoints;
    public Text coinPoints;
    public Text killPoints;
    public Text blockPoints;
    public Text bowserPoints;

    float totalTime;
    float pointsTimeResult;


    private void Start()
    {
       controlador = FindObjectOfType<Controlador>();
       carro2 = FindObjectOfType<Carro2>();
    }


    public void  MostrarPainel(int poi, string name)
    {
        Timer.stopTime = true;
        totalTime = Timer.timeLevel;

        // Calculo para fazer os pontos
        pointsTimeResult =  (totalPontosRun / Timer.timeLevel);
        poi += 100;
        poi += (int) pointsTimeResult;
        // Debug.Log(poi);


        Debug.Log("qtd:" + carro2.bowsers + "_____ pontos: " + carro2.pointsPerBowser);

        painel.SetActive(true);
        mashroom.text = carro2.mashrooms.ToString();
        coins.text = carro2.coins.ToString();
        kill_npc.text = carro2.killNpc.ToString();
        block.text = carro2.blocks.ToString();
        bowser.text = carro2.bowsers.ToString();
        points.text = poi.ToString();
        time.text = ((int) totalTime).ToString();
        mashroomPoints.text = (carro2.mashrooms * carro2.pointsPerMash).ToString();
        timePoints.text = ((int)  pointsTimeResult).ToString();
        coinPoints.text = (carro2.coins * carro2.pointsPerCoin).ToString();
        killPoints.text = ((carro2.killNpc * carro2.pointsPerKill) * -1).ToString();
        blockPoints.text = (carro2.blocks * carro2.pointsBlock).ToString();
        bowserPoints.text = ((carro2.bowsers * carro2.pointsPerBowser) * -1).ToString();

        

        if(controlador.recordsPointsAmount == 0){
            controlador.recordsPointsAmount = poi;
            controlador.recordsPointsName = name;
        }

        if(poi > controlador.recordsPointsAmount)
        {

            controlador.thirdPointsAmount = controlador.secondPointsAmount;
            controlador.thirdPointsName = controlador.secondPointsName;

            controlador.secondPointsAmount = controlador.recordsPointsAmount;
            controlador.secondPointsName = controlador.recordsPointsName;

            controlador.recordsPointsAmount = poi;
            controlador.recordsPointsName = name;

        }else if(poi < controlador.recordsPointsAmount && poi > controlador.secondPointsAmount)
        {
            controlador.thirdPointsAmount = controlador.secondPointsAmount;
            controlador.thirdPointsName = controlador.secondPointsName;

            controlador.secondPointsAmount = poi;
            controlador.secondPointsName = name;
        }else if(poi < controlador.secondPointsAmount && poi > controlador.thirdPointsAmount)
        {
            controlador.thirdPointsAmount = poi;
            controlador.thirdPointsName = name;
        }
        //  painel.transform.GetChild(0)
       
    }

    public void GoMenu(){
        SceneManager.LoadScene(0);
    }
}
