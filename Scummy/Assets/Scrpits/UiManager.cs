using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Text _PillyText;

    // Start is called before the first frame update
    void Start()
    {
        _PillyText.text = "PillyCounter: " + 0;
    }

    public void UpdateScore(int playerScore)
    {
        _PillyText.text = "PillyCounter: " + playerScore;
    }
}
