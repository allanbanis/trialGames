using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM_Spawnbubbles : MonoBehaviour {

	// Use this for initialization
	public GameObject other;
	float timer;
	void Start () {
		timer=Random.Range(0,1);
	}
	
	// Update is called once per frame
	void Update () {
		timer-=Time.deltaTime;
		if(timer<0){
			timer=Random.Range(0,2);
			Instantiate(other);
		}
		
	}
}
