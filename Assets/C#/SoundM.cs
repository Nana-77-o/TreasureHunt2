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
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Setting")
        {
            //DontDestroyOnLoad(BGM.gameObject);
        }
        else if(SceneManager.GetActiveScene().name == "StartScene")
        {

        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
