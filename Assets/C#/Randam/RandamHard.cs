using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandamHard : MonoBehaviour
{
	//少なくて広い
	public GameObject Treasyre;
	public GameObject Treasyre2;
	public GameObject Enemy;
	void Start()
	{
		for (int i = 0; i < 5; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-499.0f, 499.0f);
			float z = Random.Range(-499.0f, 499.0f);
			float y = 40.0f;

			//オブジェクトを生産
			Instantiate(Treasyre, new Vector3(x, y, z), Quaternion.identity);
		}
		for (int i = 0; i < 5; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-499.0f, 100.0f);
			float z = Random.Range(-499.0f, 100.0f);
			float y = 40.0f;

			//オブジェクトを生産
			Instantiate(Treasyre2, new Vector3(x, y, z), Quaternion.identity);
		}
		Invoke("EnemySporn", 4f);
	}
	void EnemySporn()
	{
		for (int i = 0; i < 30; i++)
		{
			//オブジェクトの座標
			float x = Random.Range(-499.0f, 499.0f);
			float z = Random.Range(-499.0f, 499.0f);
			float y = 10.0f;

			//オブジェクトを生産
			Instantiate(Enemy, new Vector3(x, y, z), Quaternion.identity);
		}
	}
}
