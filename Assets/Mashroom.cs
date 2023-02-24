using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mashroom : MonoBehaviour
{
    public GameObject carro = null;
    public GameObject mashroom;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.GetComponent<Carro2>())
        {

            Carro2 x = other.transform.root.GetComponent<Carro2>();
            x.AddMashrooms();
            // Debug.Log("Pegou Cogumelo");
            Destroy(mashroom);
        }

    }
}
