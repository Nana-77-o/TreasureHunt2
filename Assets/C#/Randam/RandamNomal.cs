using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandamNomal : MonoBehaviour
{
	public GameObject cube;
	public GameObject Treasyre2;
	public GameObject Enemy;

	void Start()
	{
		//多くて狭い
		for (int i = 0; i < 10; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-100.0f, 100.0f);
			float z = Random.Range(-100.0f, 100.0f);
			float y = 12.0f;

			//オブジェクトを生産
			Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
		}
		for (int i = 0; i < 10; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-100.0f, 100.0f);
			float z = Random.Range(-100.0f, 100.0f);
			float y = 12.0f;

			//オブジェクトを生産
			Instantiate(Treasyre2, new Vector3(x, y, z), Quaternion.identity);
		}
	}
	void EnemySporn()
	{
		for (int i = 0; i < 5; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-100.0f, 100.0f);
			float z = Random.Range(-100.0f, 100.0f);
			float y = 10.0f;

			//オブジェクトを生産
			Instantiate(Enemy, new Vector3(x, y, z), Quaternion.identity);

		}
	}
}

