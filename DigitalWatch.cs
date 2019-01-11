using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalWatch : MonoBehaviour {

    public GameObject hours;
    public GameObject minutes;
    public Material time00;
    public Material time01;
    public Material time02;
    public Material time03;
    public Material time04;
    public Material time05;
    public Material time06;
    public Material time07;
    public Material time08;
    public Material time09;
    public Material time10;
    public Material time11;
    public Material time12;
    public Material time15;
    public Material time20;
    public Material time25;
    public Material time30;
    public Material time35;
    public Material time40; 
    public Material time45;
    public Material time50;
    public Material time55;

    public float starting_hour;
    public float starting_minute;
    public float hour;
    public float minute;
    private bool once;
    // Use this for initialization
    void Start () {

        hour = starting_hour;
        once = false;

    }

    // Update is called once per frame
    void Update()
    {

        minute = starting_minute + (10 * (Time.time / 60));

        if (minute >= 60 && minute < 120 && once == false)
        {
            hour = hour + 1;
            once = true;
        }
        else if (minute >= 120 && minute < 180 && once == true)
        {
            hour = hour + 1;
            once = false;
        }
        else if (minute >= 180 && minute < 240 && once == false)
        {
            hour = hour + 1;
            once = true;
        }
        else if (minute >= 240 && minute < 300 && once == true)
        {
            hour = hour + 1;
            once = false;
        }

        if (hour == 8)
        {
            hours.GetComponent<Renderer>().material = time08;
        }
        else if (hour == 9)
        {
            hours.GetComponent<Renderer>().material = time09;
        }
        else if (hour == 10)
        {
            hours.GetComponent<Renderer>().material = time10;
        }
        else if (hour == 11)
        {
            hours.GetComponent<Renderer>().material = time11;
        }
        else if (hour == 12)
        {
            hours.GetComponent<Renderer>().material = time12;
        }
        else if (hour == 13)
        {
             hours.GetComponent<Renderer>().material = time01;
        }
        else if (hour == 14)
        {
            hours.GetComponent<Renderer>().material = time02;
        }
        else if (hour == 15)
        {
            hours.GetComponent<Renderer>().material = time03;
        }

        if ((minute >= 0 && minute < 5) || (minute >= 60 && minute < 65)|| (minute >= 120 && minute < 125))
        {
            minutes.GetComponent<Renderer>().material = time00;
        }
        else if ((minute >= 05 && minute < 10) || (minute >= 65 && minute < 70) || (minute >= 125 && minute < 130) || (minute == 185 && minute < 190))
        {
            minutes.GetComponent<Renderer>().material = time05;
        }
        else if ((minute >= 10 && minute < 15) || (minute >= 70 && minute < 75) || (minute >= 130 && minute < 135) || (minute >= 190 && minute < 195))
        {
            minutes.GetComponent<Renderer>().material = time10;
        }
        else if ((minute >= 15 && minute < 20)|| (minute >= 75 && minute < 80) || (minute >= 135 && minute < 140) || (minute >= 195 && minute < 200))
        {
            minutes.GetComponent<Renderer>().material = time15;
        }
        else if ((minute >= 20 && minute < 25) || (minute >= 80 && minute < 85) || (minute >= 140 && minute < 145) || (minute >= 200 && minute < 205))
        {
            minutes.GetComponent<Renderer>().material = time20;
        }
        else if ((minute >= 25 && minute < 30) || (minute >= 85 && minute < 90) || (minute >= 145 && minute < 150) || (minute >= 205 && minute <210))
        {
            minutes.GetComponent<Renderer>().material = time25;
        }
        else if ((minute >= 30 && minute < 35) || (minute >= 90 && minute < 95)|| (minute >= 150 && minute < 155) || (minute >= 210 && minute < 215))
        {
            minutes.GetComponent<Renderer>().material = time30;
        }
        else if ((minute >= 35 && minute < 40) || (minute >= 95 && minute < 100) || (minute >= 155 && minute < 160) || (minute >= 215 && minute < 220))
        {
            minutes.GetComponent<Renderer>().material = time35;
        }
        else if ((minute >= 40 && minute < 45) || (minute >= 100 && minute < 105) || (minute >= 160 && minute < 165) || (minute >= 220 && minute < 225))
        {
            minutes.GetComponent<Renderer>().material = time40;
        }
        else if ((minute >= 45 && minute < 50) || (minute >= 105 && minute < 110) || (minute >= 165 && minute < 170) || (minute >= 225 && minute < 230))
        {
            minutes.GetComponent<Renderer>().material = time45;
        }
        else if ((minute >= 50 && minute < 55) || (minute >= 110 && minute < 115) || (minute >= 170 && minute < 175) || (minute >= 230 && minute < 235))
        {
            minutes.GetComponent<Renderer>().material = time50;
        }
        else if ((minute >= 55 && minute < 60) || (minute >= 115 && minute < 120) || (minute >= 175 && minute < 180) || (minute >= 235 && minute < 240))
        {
            minutes.GetComponent<Renderer>().material = time55;
        }
    }
}
