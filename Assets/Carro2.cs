using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carro2 : MonoBehaviour
{

    // Start is called before the first frame update
    public Text txt;
    public Text mash;
    public Text coin_text;
    public Text laps_text;
    public Text kill_npc_text;
    public Text block_text;
    public Text points_text;
    public Text bowser_text;


    public int voltas = 0;
    public int coins = 0;
    public int mashrooms = 0;
    public int killNpc = 0;
    public int blocks = 0;
    public int bowsers = 0;
    public int totalVoltas = 2;
    public int points = 0;
    public int pointsPerMash;
    public int pointsPerCoin;
    public int pointsPerKill;
    public int pointsBlock;
    public int pointsPerBowser;


    Controlador controlador;

   private void Awake()
   {

    controlador = FindObjectOfType<Controlador>();
   }


    void Start()
    {
        txt.text = MenuController.name_user;
    }
    

    // Update is called once per frame
    void Update()
    {
        points_text.text = points.ToString();
    }

    public void SomarVoltas()
    {   
        voltas++;
        Debug.Log(voltas);
           Debug.Log(controlador.lapsAmount);
        controlador.lapsAmount = voltas;
            // Debug.Log("Demos uma volta - " + voltas.ToString());
        laps_text.text = voltas.ToString() + "/" + totalVoltas.ToString();
        // Debug.Log("Demos uma volta - " + voltas.ToString());
    }

    public void AddCoins()
    {   
        coins++;
        points += pointsPerCoin;
        coin_text.text = coins.ToString();
        // Debug.Log("Moedas: " + coins.ToString());
    }


    public void AddMashrooms()
    {   
        mashrooms++;
        points += pointsPerMash;
        mash.text = mashrooms.ToString();
        // Debug.Log("Cogumelos: " + mashrooms.ToString());
    }

    public void KillNpc()
    {   
        killNpc++;
        points -= pointsPerKill;
        kill_npc_text.text = killNpc.ToString();
    }
    
    public void AddBlock()
    {   
        blocks++;
        points += pointsBlock;
        block_text.text = blocks.ToString();
    }

    public void RemoveTime()
    {   
        Timer.timeLevel -= 5;
    }

    public void DamegeFromBowser()
    {   
        bowsers++;
        points -= pointsPerBowser;
        bowser_text.text = bowsers.ToString();
    }

    public int GetLaps(){
        return voltas;
    }


}
 