using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public void OnClikc()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("StartScene");
    }
}
