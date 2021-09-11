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

    static float countTime;
    public Text text;

    [SerializeField] private GameObject GameClereCanvas;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (count <= 4)
        {
            countTime += Time.deltaTime;
            text.text = countTime.ToString("F2");
        }
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
    public static float getscore()
    {
        return (float)countTime;
    }
}
