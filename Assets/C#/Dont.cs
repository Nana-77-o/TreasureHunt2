using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dont : MonoBehaviour
{
    public GameObject BGM;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(BGM.gameObject);
        SceneManager.LoadScene("StartScene");
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Setting")
        {
            //DontDestroyOnLoad(BGM.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "StartScene")
        {
            this.gameObject.SetActive(true);
        }
        else if(SceneManager.GetActiveScene().name == "Preload")
        {

        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
