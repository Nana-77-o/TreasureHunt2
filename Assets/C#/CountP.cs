using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountP : MonoBehaviour
{
    int count; 
    public Text TreasureCount;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Treasure")
        {
            count++;
            TreasureCount.text = +count + "/10";
            Destroy(collision.gameObject);
        }
        if (count == 10 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
