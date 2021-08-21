using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class setVolume : MonoBehaviour
{

    public AudioMixer mixer;
    [SerializeField] private string mixerFloatName;
     private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();

        SetLevel(PlayerPrefs.GetFloat(mixerFloatName + "volume"));
        slider.value = PlayerPrefs.GetFloat(mixerFloatName + "volume");
    }
    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat(mixerFloatName, Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat(mixerFloatName + "volume", sliderValue);
    }
}
