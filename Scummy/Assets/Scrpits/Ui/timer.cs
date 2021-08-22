using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;


    [Space(50)]

    [SerializeField] private bool playing = true;
    [SerializeField]private float timerFloat;
    private UiManager uim;

    private void Start()
    {
        uim = FindObjectOfType<UiManager>();
    }

    private void Update()
    {
        if (playing)
        {
            timerFloat += Time.deltaTime;
            //int minutes = Mathf.FloorToInt(timerFloat / 60f);
            //int seconds = Mathf.FloorToInt(timerFloat % 60f);
            //int milliseconds = Mathf.FloorToInt((timerFloat * 100f) % 100f);

            int seconds = (int)(timerFloat % 60);
            int minutes = (int)(timerFloat / 60) % 60;
            int hours = (int)(timerFloat / 3600);

            timerText.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }

    public void stopTimer()
    {
        playing = false;

        //this commented line should happen on win to set the highscore 
        //uim.checkHighscore(timerFloat);
    }
};
