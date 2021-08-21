using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class mainmenu : MonoBehaviour
{

    private bool isInOptions;
    [SerializeField] GameObject optionsPanel;
    [SerializeField] GameObject mainPanel;

    public void onPress( string levelname)
    {
        if (levelname == "quit")
        {
            Application.Quit();
        }
        else if(levelname == "play")
        {
            SceneManager.LoadScene("game");
        }
        else if(levelname == "options")
        {
            if (!isInOptions)
            {
                optionsPanel.SetActive(true);
                mainPanel.SetActive(false);
                isInOptions = true;
            }
            else
            {
                optionsPanel.SetActive(false);
                mainPanel.SetActive(true);
                isInOptions = false;
            }
        }
    }
}
