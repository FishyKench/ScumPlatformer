using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    [Header("References")]
    private UiManager _uim;

    [Space]
    
    [Header("level info")]
    [SerializeField] private string _levelName;
    [SerializeField] private int _maxscore;
    
    [SerializeField]private bool didActivate = false;

    private void Start()
    {
        _uim = FindObjectOfType<UiManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !didActivate)
        {
            updateLevelStats();
        }
    }

    private void updateLevelStats()
    {
        _uim.maxScore = _maxscore;
        //_uim._levelNameText.text = _levelName;
        _uim.UpdateScore(0);
        didActivate = true;
    }
}
