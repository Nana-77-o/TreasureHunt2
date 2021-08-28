using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoJanp : MonoBehaviour
{
    [SerializeField]// SerializeFieldと書くとその次の変数がエディタ上で数値を調整可能になる
    private float JumpPower = 400;// ジャンプ力
    private Rigidbody rb;// Rigidbodyを扱うための変数
    private float JumpCount = 0;

    // Start is called before the first frame update    
    void Start()
    {
        rb = GetComponent<Rigidbody>();//  rbにRigidbodyの値を代入する
    }

    // Update is called once per frame
    void Update()
    {
        if (JumpCount <= 1)//  もし、Groundedがtrueなら、
        {
            if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
            {
                JumpCount++;//  Groundedをfalseにする
                rb.AddForce(Vector3.up * JumpPower);//  上にJumpPower分力をかける
            }
        }
    }

    void OnCollisionEnter(Collision other)//  地面に触れた時の処理
    {
        if (other.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            JumpCount = 0;//  Groundedをtrueにする
        }
    }
}
