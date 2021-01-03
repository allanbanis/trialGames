using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour {
    bool add_force = true;
    GameObject manager,mainCamera;
    public Sprite deadSprite;
	// Use this for initialization
	void Start () {
        manager = GameObject.Find("GameManager").gameObject;   
        mainCamera=GameObject.Find("Main Camera").gameObject;  
    }
    float timer = 0;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && add_force)
        {
            add_force = false;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 800f);

        }
        if(transform.position.x<-9.5f){
             manager.GetComponent<GameManager>().gameOver = true;
            GetComponent<SpriteRenderer>().sprite = deadSprite;
        }
        if(manager.GetComponent<GameManager>().gameOver && manager.GetComponent<GameManager>().deadObject){
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(manager.GetComponent<GameManager>().deadObject.transform.position.x,manager.GetComponent<GameManager>().deadObject.transform.position.y,-10), timer);
            mainCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(mainCamera.GetComponent<Camera>().orthographicSize, 1, timer);
            timer += Time.deltaTime / 3;
        }
       
       
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            add_force = true;
        }
        if(collision.gameObject.tag == "Enemy"){
            manager.GetComponent<GameManager>().deadObject = gameObject;
            manager.GetComponent<GameManager>().gameOver = true;
            GetComponent<SpriteRenderer>().sprite = deadSprite;

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //add_force = false;
        }
    }
}
