using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text text;
    public float countTime;
    void Start()
    {
        countTime = Count.getscore();
        text.text = countTime.ToString("F2");
    }
}
