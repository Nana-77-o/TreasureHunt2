using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject Player;
    public Transform target;

    public AudioClip EnemySound;
    AudioSource audioSoure;

    Vector3 playerPos;
    float distance;
    public float speed = 0.1f;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
    }
    private void Update()
    {
        playerPos = Player.transform.position;
        distance = Vector3.Distance(this.transform.position, playerPos);

        if(distance < 15)
        { 
            audioSoure.PlayOneShot(EnemySound);
            //targetの方に少しずつ向きが変わる
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);

            //targetに向かって進む
            transform.position += transform.forward * speed;                      
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
