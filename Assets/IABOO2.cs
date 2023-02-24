using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IABOO2 : MonoBehaviour
{

    public GameObject carro = null;
    public GameObject npc;

    public NavMeshAgent agent;
    public GameObject Player;
    public Animator anim;

    private float ContadorMove;
    private bool indo;
    private bool vindo;
    public GameObject ponto1;
    public GameObject ponto2;
    public GameObject ponto3;
    public GameObject ponto4;
    public GameObject pontoAtual;

    public static bool estaMorto = false;
    // Start is called before the first frame update
    void Start()
    {
        ponto1 = GameObject.Find("BooSecondPonto1");
        ponto2 = GameObject.Find("BooSecondPonto2");
        ponto3 = GameObject.Find("BooSecondPonto3");
        ponto4 = GameObject.Find("BooSecondPonto4");

        Invoke("DelayInicio",1);
        estaMorto = false;
    }

    public void DelayInicio()
    {
        vindo = true;
        pontoAtual = ponto1;
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis(" Vertical");

        float distanciaP1 = Vector3.Distance(ponto1.transform.position, transform.position);
        float distanciaP2 = Vector3.Distance(ponto2.transform.position, transform.position);
        float distanciaP3 = Vector3.Distance(ponto3.transform.position, transform.position);
        float distanciaP4 = Vector3.Distance(ponto4.transform.position, transform.position);

        // agent.SetDestination(ponto2.transform.position);

        if(estaMorto == false){
           
            
            anim.SetBool("walking", true);

            if(vindo)
            {

                agent.SetDestination(pontoAtual.transform.position);
                if(distanciaP1 <= agent.stoppingDistance)
                {
                    pontoAtual = ponto2;
                }
                if(distanciaP2 <= agent.stoppingDistance)
                {
                    pontoAtual = ponto3;
                }
                 if(distanciaP3 <= agent.stoppingDistance)
                {
                    pontoAtual = ponto4;
                }
                  if(distanciaP4 <= agent.stoppingDistance)
                {
                    vindo = false;
                    indo = true;
                    pontoAtual = ponto3;
                }
             
            }
            if(indo)
            {

                agent.SetDestination(pontoAtual.transform.position);
                if(distanciaP4 <= agent.stoppingDistance)
                {
                    pontoAtual = ponto3;
                }
                if(distanciaP3 <= agent.stoppingDistance)
                {
                    pontoAtual = ponto2;
                }
                if(distanciaP2 <= agent.stoppingDistance)
                {
                    pontoAtual = ponto1;
                }
                 if(distanciaP1 <= agent.stoppingDistance)
                {
                    vindo = true;
                    indo = false;
                    pontoAtual = ponto2;
                }
               
            }
        }


    }

}
