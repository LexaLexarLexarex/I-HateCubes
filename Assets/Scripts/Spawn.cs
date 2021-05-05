using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

	public GameObject[] objects;
	private GameObject inst_obj;
	float memTime = Time.time;
	float timerTime;
	public  float constTime;

	void Start()
	{
	}

    private void Update()
    {
			
			timerTime = Time.time - memTime; //время, прошедшее со времени старта таймера
			if (timerTime > constTime)
			{
				int rand = Random.Range(0, objects.Length);
				inst_obj = Instantiate(objects[rand], objects[rand].transform.position, Quaternion.identity) as GameObject;
				inst_obj.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
				memTime = Time.time;
			}
	}

}
