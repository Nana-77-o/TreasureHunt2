using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
    private int count = 0;
    public Text TreasureCount;
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Treasure")
        {
            count++;
            TreasureCount.text =+ count +"/5" ;
            Destroy(collision.gameObject);
        }
        if(count == 5 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
