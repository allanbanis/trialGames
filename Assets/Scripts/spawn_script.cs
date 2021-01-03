using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour {
public float pwrtme=2f;
public float enmtme=4f;
float spwrtme;
float senmtme;
public GameObject pwrUp,enm;
	// Use this for initialization
	void Start () {
		spwrtme=0f;
		senmtme=0f;
	}
	
	// Update is called once per frame
	void Update () {
		//increase time
		spwrtme+=Time.deltaTime;
		senmtme+=Time.deltaTime;
		if(spwrtme>pwrtme){
			spwrtme=0f;
			float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
 
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
			Instantiate(pwrUp,spawnPosition,Quaternion.identity);
		}
		if(senmtme>enmtme){
			senmtme=0f;
			float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
 
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
			Instantiate(enm,spawnPosition,Quaternion.identity);
		}
	}
}
