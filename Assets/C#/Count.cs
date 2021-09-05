using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
    private int count = 0;
    public Text TreasureCount;
    public AudioClip sound1;
    AudioSource audioSoure;
    [SerializeField] private GameObject GameClereCanvas;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Treasure")
        {
            audioSoure.PlayOneShot(sound1);
            count++;
            TreasureCount.text =+ count +"/5" ;
            Destroy(collision.gameObject);
            if(count == 5)
            {
                GameClereCanvas.SetActive(true);
            }
        }
       
    }
}
