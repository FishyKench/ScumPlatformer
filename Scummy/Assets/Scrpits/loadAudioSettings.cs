using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class loadAudioSettings : MonoBehaviour
{
    float mastervolume;
    float sfxvolume;
    float musicvolume;

    public AudioMixer mainMixer;
    void Start()
    {
        SetMixerFloats();
    }

    void SetMixerFloats()
    {
        mastervolume = PlayerPrefs.GetFloat("masterVolumevolume");
        sfxvolume = PlayerPrefs.GetFloat("sfxVolumevolume");
        musicvolume = PlayerPrefs.GetFloat("musicVolumevolume");

        print("The volume of " + "mastervolume" + " is : " + mastervolume);
        print("The volume of " + "sfxVolume" + " is : " + sfxvolume);
        print("The volume of " + "musicVolume" + " is : " + musicvolume);

        mainMixer.SetFloat("masterVolume",Mathf.Log10(mastervolume) * 20);
        mainMixer.SetFloat("sfxVolume", Mathf.Log10(sfxvolume) * 20);
        mainMixer.SetFloat("musicVolume", Mathf.Log10(musicvolume) * 20 );
    }

}
