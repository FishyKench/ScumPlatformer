using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private string[] tips;

    [Space(50)]

    [SerializeField]
    private TextMeshProUGUI _PillyText;
    private Player _player;
    private GameOverScreen gameoverscreen;
    private timer timer;
    
    public int maxScore;

    [Header("Gameover Panel")]
    public GameObject gameoverPanel;
    public TextMeshProUGUI tipsText;
    public TextMeshProUGUI time;
    public TextMeshProUGUI bestTime;

    [Header("Win screen")]
    public GameObject winScreen;
    public TextMeshProUGUI timeEnd;
    public TextMeshProUGUI bestTimeEnd;
    public TextMeshProUGUI pillyCountEnd;

    void Start()
    {
        Cursor.visible = false;
        gameoverPanel.SetActive(false);
        winScreen.SetActive(false);
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        timer = FindObjectOfType<timer>();
        Debug.Log(maxScore);
    }

    public void UpdateScore(int playerScore)
    {
        _PillyText.text = playerScore.ToString() + " / " + maxScore;
    }

    public void ShowGameoverPanel()
    {
        Cursor.visible = true;
        tipsText.text = tips[Random.Range(0, tips.Length)];
        gameoverPanel.SetActive(true);

        time.text = timer.timerText.text;
        timer.stopTimer();
    }

    public void checkHighscore(float time)
    {
        Debug.Log("started checking for highscore");
        if (PlayerPrefs.GetFloat("highscore", 999999) >= time)
        {
            PlayerPrefs.SetFloat("highscore", time);
            // int minutes = Mathf.FloorToInt(time / 60f);
            //int seconds = Mathf.FloorToInt(time % 60f);
            //int milliseconds = Mathf.FloorToInt((time * 100f) % 100f);

            int hours = (int)(time / 3600);
            int seconds = (int)(time % 60);
            int minutes = (int)(time / 60) % 60;

            bestTime.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
            bestTimeEnd.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

        }
        else
        {
            //int minutesPref = Mathf.FloorToInt(PlayerPrefs.GetFloat("highscore") / 60f);
            //int secondsPref = Mathf.FloorToInt(PlayerPrefs.GetFloat("highscore") % 60f);
            //int millisecondsPref = Mathf.FloorToInt((PlayerPrefs.GetFloat("highscore") * 100f) % 100f);

            int hoursPref = (int)(PlayerPrefs.GetFloat("highscore") / 3600);
            int secondsPref = (int)(PlayerPrefs.GetFloat("highscore") % 60);
            int minutesPref = (int)(PlayerPrefs.GetFloat("highscore") / 60) % 60;

            bestTime.text = hoursPref.ToString("00") + ":" + minutesPref.ToString("00") + ":" + secondsPref.ToString("00");
            bestTimeEnd.text = hoursPref.ToString("00") + ":" + minutesPref.ToString("00") + ":" + secondsPref.ToString("00");
        }
    }

    public void win()
    {
        Cursor.visible = true;
        winScreen.SetActive(true);

        timeEnd.text = timer.timerText.text;
        timer.stopTimer();

        pillyCountEnd.text = _PillyText.text;
    }
 }
