using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_ws : MonoBehaviour {
	public bool gameOver;
	public Sprite puff;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameOver){
	    if(Input.GetKeyDown(KeyCode.LeftArrow)){
			//transform.Translate( new Vector2(-1,0) * Time.deltaTime* 10);
			transform.eulerAngles=  new Vector3(
    			transform.eulerAngles.x,
    			transform.eulerAngles.y,
    			transform.eulerAngles.z+20
);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
				transform.Translate( new Vector2(0,1) * Time.deltaTime* 5);
		}
		if(Input.GetKeyDown(KeyCode.RightArrow)){
				//transform.Translate( new Vector2(1,0) * Time.deltaTime* 10);
				transform.eulerAngles=  new Vector3(
    			transform.eulerAngles.x,
    			transform.eulerAngles.y,
    			transform.eulerAngles.z-20
);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
				transform.Translate( new Vector2(0,-1) * Time.deltaTime* 3);
	
		}
	}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag=="Enemy"){
			//Destroy(gameObject);
			gameOver=true;
			GetComponent<SpriteRenderer>().sprite=puff;

		}
		if(other.gameObject.tag=="Ally"){
			Destroy(other.gameObject);
		}
	}
}
