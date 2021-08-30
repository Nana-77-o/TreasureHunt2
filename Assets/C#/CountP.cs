using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountP : MonoBehaviour
{
    int count; 
    public Text TreasureCount;
    public AudioClip sound1;
    AudioSource audioSoure;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Treasure")
        {
            audioSoure.PlayOneShot(sound1);
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
