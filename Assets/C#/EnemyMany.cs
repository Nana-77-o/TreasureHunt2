using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMany : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public GameObject BackCamera;
    public float speed;
    public float dashSpeed;
    public GameObject Enemy;
    private Transform PlayerTransform;
    private Transform CameraTransform;

    void Start()
    {

        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();
        for (int i = 0; i < 200; i++)
        {
            //オブジェクトの座標
            float x = Random.Range(-499.0f, 100.0f);
            float z = Random.Range(-499.0f, 100.0f);
            float y = 7.0f;

            //オブジェクトを生産
            Instantiate(Enemy, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        PlayerTransform.transform.Rotate(0, X_Rotation, 0);
        CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);


        float angleDir = PlayerTransform.transform.eulerAngles.y * (Mathf.PI / 180.0f);
        Vector3 dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));
        Vector3 dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));


        if (Input.GetKey(KeyCode.W))
        {
            PlayerTransform.transform.position += -dir2 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.transform.position += dir1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.transform.position += -dir1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerTransform.transform.position += dir2 * speed * Time.deltaTime;
        }
        if (Input.GetKey("left shift") && Input.GetKey(KeyCode.W))
        {
            PlayerTransform.transform.position += -dir2 * dashSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            BackCamera.SetActive(true);

        }
        else
        {
            BackCamera.SetActive(false);
        }
    }
}
