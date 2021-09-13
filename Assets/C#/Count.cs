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
    float startTime;

    [SerializeField] private GameObject GameClereCanvas;
    [SerializeField] private GameObject fakeClereCanvas;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (count <= 4)
        {
            startTime += Time.deltaTime;
            if (startTime >= 4 )
            {
                countTime += Time.deltaTime;
                text.text = countTime.ToString("F2");
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            fakeClereCanvas.SetActive(false);
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
        if (collision.gameObject.tag == "Treasyre2")
        {
            fakeClereCanvas.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
    public static float getscore()
    {
        return (float)countTime;
    }
}
