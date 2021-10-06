using UnityEngine;
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

    [SerializeField] private GameObject GameClereCanvas;
    [SerializeField] private GameObject fakeClereCanvas;
    [SerializeField] private GameObject Result;
    [SerializeField] GameObject Player;
    public bool isTimeUp;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
        InvokeRepeating("Call", 4, 0.01f);
        isTimeUp = false;
    }
    void Update()
    {
        if (count <= 4)
        {
            timetext.text = countTime.ToString("F2");
        }
        else if (count == 5)
        {
            isTimeUp = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            fakeClereCanvas.SetActive(false);
        }
    }
    void Call()
    {
        countTime += Time.deltaTime;
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
        }
    }
}
