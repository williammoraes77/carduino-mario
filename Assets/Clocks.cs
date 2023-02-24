using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clocks : MonoBehaviour
{

    public GameObject carro = null;
    public GameObject clock;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.GetComponent<Carro2>())
        {

            Carro2 x = other.transform.root.GetComponent<Carro2>();
            x.RemoveTime();
            // Debug.Log("Pegou moeda");

            Destroy(clock);
        }

    }
}
