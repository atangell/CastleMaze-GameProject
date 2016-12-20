using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CountdownTimer : MonoBehaviour
{

    public Text timerText;
    private float startTimer;
    private bool finished = false;
    String Score;
    int time;
    // Use this for initialization
    void Start()
    {
        startTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (finished)

            return;



        float t = Time.time - startTimer;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

        time = Convert.ToInt32(minutes);

        if (time >= 0 && time < 1)
        {
            Score = "30";
        }

        else if (time >= 1 && time < 2)
        {
            Score = "20";
        }
        else if (time >= 2 && time <= 3)
        {
            Score = "10";
        }
        else
        {
            Score = "0";
        }

    }
    public void finish()
    {
        finished = true;
        timerText.color = Color.red;

        timerText.text = "Your Score is " + Score;

    }
}