using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _PillyText;
    private Player _player;
    
    public TextMeshProUGUI _levelNameText;
    public int maxScore;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Debug.Log(maxScore);
    }

    public void UpdateScore(int playerScore)
    {
        _PillyText.text = playerScore.ToString() + " / " + maxScore;
    }
}
