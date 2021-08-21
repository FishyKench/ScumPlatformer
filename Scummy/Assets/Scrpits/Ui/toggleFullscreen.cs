using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleFullscreen : MonoBehaviour
{
    public bool isFullscreen;

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
        if (fullscreen)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            PlayerPrefs.SetInt("fullscreen", 1);
        }

        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            PlayerPrefs.SetInt("fullscreen", 0);
        }
    }
}
