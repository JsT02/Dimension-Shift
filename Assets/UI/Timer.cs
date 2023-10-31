using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI TimeCount;
    private int MinutesTens;
    private int Minutes;
    private int SecondsTens;
    private int Seconds;
    // Update is called once per frame
    void Update()
    {
        // Digits

        Seconds = (int)Time.realtimeSinceStartup;
        if(Seconds > 10)
        {

            Seconds = 0;
            SecondsTens++;

        }
        if(SecondsTens > 6)
        {

            SecondsTens = 0;
            Minutes++;

        }
        if(Minutes > 10)
        {

            Minutes = 0;
            MinutesTens++;

        }
        if (MinutesTens > 6) MinutesTens = 0;
        
        TimeCount.text = new string("Time: " + MinutesTens + Minutes + ":" + SecondsTens + Seconds);

    }
}
