using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Setting");
    }
    public void Click()
    {
        SceneManager.LoadScene("Easy");
    }
    public void Nomal()
    {
        SceneManager.LoadScene("Nomal");
    }
    public void Hard()
    {
        SceneManager.LoadScene("Hard");
    }
    public void Expert()
    {
        SceneManager.LoadScene("Expert");
    }
    public void Pirate()
    {
        SceneManager.LoadScene("Pirate");
    }

}
