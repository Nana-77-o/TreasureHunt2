using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundOption : MonoBehaviour
{
    [SerializeField] private GameObject SoundOptionCanvas;
    [SerializeField] private AudioMixerSnapshot gameSoundShot;
    [SerializeField] private AudioMixerSnapshot optionSoundShot;
    [SerializeField] private AudioMixer audioMixer;
   

    void Update()
    {
        if (Input.GetKeyDown("4"))
        {
            SoundOptionCanvas.SetActive(!SoundOptionCanvas.activeSelf);

            if (SoundOptionCanvas.activeSelf)
            {
                optionSoundShot.TransitionTo(0.01f);
            }
            else
            {
                gameSoundShot.TransitionTo(0.01f);
            }
        }
    }

    public void SetMaster(float volume)
    {
        audioMixer.SetFloat("MasterVol", volume);
    }

    public void SetBGM(float volume)
    {
        audioMixer.SetFloat("BGMVol", volume);
    }

    public void SetSE(float volume)
    {
        audioMixer.SetFloat("SEVol", volume);
    }
}
