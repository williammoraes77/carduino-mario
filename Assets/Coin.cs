using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject carro = null;
    public GameObject coin;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.GetComponent<Carro2>())
        {

            Carro2 x = other.transform.root.GetComponent<Carro2>();
            x.AddCoins();
            // Debug.Log("Pegou moeda");
            Debug.Log(MenuController.name_user);
            Destroy(coin);
        }

    }
}
