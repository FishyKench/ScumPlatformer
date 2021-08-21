using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class loadAudioSettings : MonoBehaviour
{
    public AudioMixer mainMixer;
    void Start()
    {
        mainMixer.SetFloat("masterVolume", PlayerPrefs.GetFloat("masterVolumevolume"));
        mainMixer.SetFloat("sfxVolume", PlayerPrefs.GetFloat("sfxVolumevolume"));
        mainMixer.SetFloat("musicVolume", PlayerPrefs.GetFloat("musicVolumevolume"));
    }

}
