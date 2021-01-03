using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {
    public Sprite[] puffSprite;
    public bool inActive = false;
    // Use this for initialization
    float timer = 0f;
  	private void Update()
	{
        
        if (inActive)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, Mathf.Lerp(1, 0, timer));
            timer += Time.deltaTime;
            if(timer>1){
                Destroy(gameObject);
            }
            if(timer>0.10f){
                
               
                GetComponent<SpriteRenderer>().sprite = puffSprite[1];
            }
            if (timer > 0.40f)
            {
                GetComponent<SpriteRenderer>().sprite = puffSprite[2];
            }if (timer > 0.70f)
            {
                GetComponent<SpriteRenderer>().sprite = puffSprite[3];
            }

        }
        else{
            if (!GameObject.Find("GameManager").GetComponent<GameManager>().gameOver)
            {
                transform.position += Vector3.left * Time.deltaTime * 10f;
                if (transform.position.x < -17.6f)
                {
                    Destroy(gameObject);
                    }
            }
        }
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag=="Player"){
            inActive = true;
            GetComponent<SpriteRenderer>().sprite = puffSprite[0];
        }
	}
}
