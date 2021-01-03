using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlScript : MonoBehaviour {
    public GameObject mouth;
    bool gameover = false;
    float timer = 0f;
    public Sprite mouthclose, mouthopen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gameover){
            timer += Time.deltaTime;
            if(timer>0.5f){
                timer = 0;
                if(mouth.GetComponent<SpriteRenderer>().sprite==mouthclose){
                   // Debug.Log("MouthOpen");
                    mouth.GetComponent<SpriteRenderer>().sprite = mouthopen;
                }else{ 
                   // Debug.Log("MouthClose");
                    mouth.GetComponent<SpriteRenderer>().sprite = mouthclose;
                }
            }
            return;
        }
        if(GameObject.Find("GameManager").GetComponent<GameManager>().gameOver){
            return;
        }
        transform.position += Vector3.left * Time.deltaTime * 10f;
        if (transform.position.x < -17.6f)
        { Destroy(gameObject);}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        
        if(collision.gameObject.tag=="Player"){
            gameover = true;
            //  collision.gameObject.GetComponent<SpriteRenderer>().sprite=null;
            Debug.Log(collision.gameObject);
            collision.gameObject.SetActive(false);
            mouth.SetActive(true);
          
        }
	}
}
