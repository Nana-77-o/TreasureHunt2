using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public bool DontDestroyEnabled = true;


    public void OnClick()
    {
        /*if (SceneManager.LoadScene("Setting"))
        { 
          int numMusicPlayers = FindObjectsOfType<Setting>().Length;
          if (numMusicPlayers > 1)
          {
            Destroy(gameObject);
          }
          else
          {
            DontDestroyOnLoad(gameObject);
          }
        }
        else
        {
            Destroy(gameObject);
        }*/
            SceneManager.LoadScene("Setting");
        
    }
}
