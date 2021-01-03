using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingScript : MonoBehaviour {
    public float speed =10f;
    // Use this for initialization
    GameObject manager;
    public bool added_force = false;
	void Start () {
        manager = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
        if (!added_force)
        {
            if (transform.position.y > 0.2f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime * speed, transform.position.z);
            }
            if (transform.position.y < 0.2f)
            {

                transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, transform.position.z);
            }
        }
        //if (GetComponent<Rigidbody2D>().velocity.y < 0.01f)
        //{
        //    added_force = false;
        //}
        if (Input.GetMouseButtonDown(0) )
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * 300f);
            added_force = true;

        }

        if(transform.position.x<-9f){
            manager.GetComponent<GameManager>().deadObject = gameObject;
            manager.GetComponent<GameManager>().gameOver = true;
        }

	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag=="Ground"){
            added_force = false;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            manager.GetComponent<GameManager>().deadObject = gameObject;
            manager.GetComponent<GameManager>().gameOver = true;
           

        }
	}
}
