using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    public AudioClip EnemySound;
    AudioSource audioSoure;
    // Start is called before the first frame update
    void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
