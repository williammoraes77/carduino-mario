using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Meta : MonoBehaviour
{

    Checkpoint[] checkpoints;
    Controlador controlador;

    public FimCorrida fim;
    public int lapsNumber;
    public GameObject WallStart;

    bool wallOn = true;

   private void Awake()
   {
    // carregar os checkpoints
    checkpoints = FindObjectsOfType<Checkpoint>();

    controlador = FindObjectOfType<Controlador>();

    fim = FindObjectOfType<FimCorrida>();
   }

   private void OnTriggerEnter(Collider other)
   {
    if(wallOn){
        WallStart.SetActive(false);
        wallOn = false;
    }
    Carro2 x = other.transform.root.GetComponent<Carro2>();

    foreach (Checkpoint ch in checkpoints)
    {
        if(!ch.PassouCarro())
        {

            Debug.Log("Volta invalidada!");

            ResetCheckpoints();

            return;
        }
    }

    x.SomarVoltas();
    // Debug.Log(controlador.playerAtual);
    if(x.GetLaps() == lapsNumber)
    {
        fim.MostrarPainel(x.points, controlador.playerAtual);
    }
    ResetCheckpoints();

   }

   void ResetCheckpoints()
   {
    foreach (Checkpoint cha in checkpoints)
    {
        cha.carro = null;
    }
   }

 
}
 