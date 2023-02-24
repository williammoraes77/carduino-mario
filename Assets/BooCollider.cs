using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooCollider : MonoBehaviour
{


    public GameObject boo;
    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
       boo.SetActive(true);
        
    }
}
