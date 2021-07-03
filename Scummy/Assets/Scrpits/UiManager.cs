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

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        _PillyText.text = _player.score.ToString() + " / " + _player.maxScore;
    }

    public void UpdateScore(int playerScore)
    {
        _PillyText.text = playerScore.ToString() + " / " + _player.maxScore;
    }
}
