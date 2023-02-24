using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTrap : MonoBehaviour
{
    [SerializeField]
    public GameObject point1;

     [SerializeField]
    public GameObject point2;

    public float speed;
    private int laps;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.root.GetComponent<Carro2>())
        {
            Carro2 car = other.transform.root.GetComponent<Carro2>();
            laps = car.GetLaps();
            // Debug.Log(laps);
            if(laps == 2){
                StartCoroutine(MoveAtoB(point1, point2,speed));
            }
        }
        
    }

    IEnumerator MoveAtoB(GameObject gameObjectA, GameObject gameObjectB, float speedTranslations)
    {
        while(gameObjectA.transform.position!=gameObjectB.transform.position)
        {
            gameObjectA.transform.position = Vector3.MoveTowards(gameObjectA.transform.position,gameObjectB.transform.position, speedTranslations*Time.deltaTime);
            yield return null;
        }
    
    }
}
