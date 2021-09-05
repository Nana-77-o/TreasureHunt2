using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	[SerializeField]
	private Text _textCountdown;
    private float countDown = 3;

	[SerializeField] 
	private GameObject Count;

    public void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 3)
        {
            _textCountdown.text = "3";
            if (countDown <= 2)
            {
                _textCountdown.text = "2";
                if (countDown <= 1)
                {
                    _textCountdown.text = "1";
                    if (countDown <= 0)
                    {
                        _textCountdown.text = "GO!";
                        if (countDown <= -1)
                        {
                            Count.SetActive(false);
                        }
                    }
                    
                }
            }
        }
    }
}
