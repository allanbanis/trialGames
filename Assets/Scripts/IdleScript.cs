﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
	private void OnCollisionStay2D(Collision2D collision)
	{
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10f);
	}
}
