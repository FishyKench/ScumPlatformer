using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleFullscreen : MonoBehaviour
{

    private void Start()
    {
        if(PlayerPrefs.GetInt("fullscreen") == 1)
        {
            setFullscreen(true);
        }
        else
        {
            setFullscreen(false);
        }
    }
    public void setFullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
        print(Screen.fullScreen);

        if (fullscreen)
            PlayerPrefs.SetInt("fulscreen", 1);
        else
            PlayerPrefs.SetInt("fullscreen", 0);
    }
}
