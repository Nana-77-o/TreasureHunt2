using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starts : MonoBehaviour
{
    public GameObject BGM;
    public void OnClick()
    {
        SceneManager.LoadScene("StartScene");
    }
}
