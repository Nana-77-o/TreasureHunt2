using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bgm : MonoBehaviour
{
    AudioSource m_AudioSource;
    public Slider slider;
    private bool m_Play;
    public bool m_ToggleChange;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_Play = true;
    }

    // Update is called once per frame
    void Update()
    {
        m_AudioSource.volume = slider.GetComponent<Slider>().normalizedValue;
    }
}
