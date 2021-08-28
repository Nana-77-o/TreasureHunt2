using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pirate : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Pirate");
    }
}
