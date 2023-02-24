using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeLevel;
    public Text timeLevelText;
    public static bool stopTime;

    void Start()
    {
        stopTime = false;
        timeLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!stopTime){
            timeLevel = timeLevel + Time.deltaTime;
            timeLevelText.text = timeLevel.ToString("0");
        }
    }
}
