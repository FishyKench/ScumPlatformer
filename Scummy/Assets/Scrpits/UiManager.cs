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
    
    public int maxScore;
    public GameObject gameoverPanel;
    public TextMeshProUGUI tipsText;

    void Start()
    {
        gameoverPanel.SetActive(false);
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Debug.Log(maxScore);
    }

    public void UpdateScore(int playerScore)
    {
        _PillyText.text = playerScore.ToString() + " / " + maxScore;
    }

    public void ShowGameoverPanel()
    {
        tipsText.text = tips[Random.Range(0, tips.Length)];
        gameoverPanel.SetActive(true);
    }
}
