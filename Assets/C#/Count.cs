using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    private int count = 0;
    public Text TreasureCount;

    public AudioClip sound1;
    AudioSource audioSoure;

    static float countTime;
    public Text timetext;
    float startTime;

    [SerializeField] private GameObject GameClereCanvas;
    [SerializeField] private GameObject fakeClereCanvas;
    [SerializeField] GameObject Player;

    private void Start()
    {
        audioSoure = GetComponent<AudioSource>();
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
