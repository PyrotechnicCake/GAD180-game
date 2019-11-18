using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    //Initialize timer
    public float timer;
    public float minutes;
    public float seconds;
    public Text timerTime;


    public IEnumerator TimerTick()
        {
            yield return new WaitForSeconds(1);
            timer -= 1;
            StartCoroutine(TimerTick());
        }

    // Start is called before the first frame update
    void Start()
    {
        timer = 120;
        StartCoroutine(TimerTick());
    }

    // Update is called once per frame
    void Update()
    {
        //update timer
        minutes = Mathf.Floor(timer / 60);
        seconds = Mathf.FloorToInt(timer % 60);
        timerTime.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
