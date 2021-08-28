﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randam : MonoBehaviour
{
	public GameObject cube;
	float time = 0.0f;
	
	void Start()
	{
		for (int i = 0; i < 5; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-100.0f, 100.0f);
			float z = Random.Range(-100.0f, 100.0f);
			float y = 7.0f;
			
			//オブジェクトを生産
			Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
		}
	}
	
}