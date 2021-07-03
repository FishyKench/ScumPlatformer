using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _PillyText;

    void Start()
    {
        _PillyText.text = "0";
    }

    public void UpdateScore(int playerScore)
    {
        _PillyText.text = playerScore.ToString();
    }
}
