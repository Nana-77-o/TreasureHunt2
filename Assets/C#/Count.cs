﻿using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    private int count = 0;
    public Text TreasureCount;
    public AudioClip sound1;
    AudioSource audioSoure;

    float countTime;
    public Text timetext;
    public Text risultText;
    float startTime;

    [SerializeField] private GameObject GameClereCanvas;
    [SerializeField] private GameObject fakeClereCanvas;
    [SerializeField] private GameObject Result;
    [SerializeField] GameObject Player;
    public GameObject Enemy;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
        Enemy = GameObject.FindWithTag("Enemy");
    }
    void Update()
    {
        if (count <= 4)
        {
            startTime += Time.deltaTime;
            if (startTime >= 4)
            {
                countTime += Time.deltaTime;
                timetext.text = countTime.ToString("F2");
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            fakeClereCanvas.SetActive(false);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Treasure")
        {
            audioSoure.PlayOneShot(sound1);
            count++;
            TreasureCount.text = +count + "/5";
            Destroy(collision.gameObject);
            if (count == 5)
            {
                GameClereCanvas.SetActive(true);
                Player.SetActive(false);
                risultText.text = countTime.ToString("F2");
            }
        }
        if (collision.gameObject.tag == "Treasyre2")
        {
            fakeClereCanvas.SetActive(true);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag =="Enemy")
        {
            Result.SetActive(true);
            
            Player.SetActive(false);
            Enemy.SetActive(false);
        }
    }
}
