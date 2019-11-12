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

    // Start is called before the first frame update
    void Start()
    {
        timer = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //update timer
        timer -= Time.deltaTime;
        minutes = (timer / 60);
        seconds = (timer - minutes * 60);
        timerTime.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
