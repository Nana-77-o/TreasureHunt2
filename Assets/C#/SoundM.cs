using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundM : MonoBehaviour
{
    public AudioSource BGM;
    void Start()
    {
        DontDestroyOnLoad(BGM.gameObject);
    }
}
