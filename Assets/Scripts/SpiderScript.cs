using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderScript : MonoBehaviour {
    public GameObject web;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("GameManager").GetComponent<GameManager>().gameOver)
        {
            return;
        }
        if(!web){
            transform.position += Vector3.down * Time.deltaTime * 10f;
            if (transform.position.y < -5.6f)
            {
                Destroy(gameObject);
               
            }
            return;
        }
        web.transform.position += Vector3.left * Time.deltaTime * 10f;
        transform.position += Vector3.left * Time.deltaTime * 10f;
        if (transform.position.x < -17.6f)
        { Destroy(gameObject);
            Destroy(web);
        }
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag=="Player"){
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(web);
        }
	}
}
