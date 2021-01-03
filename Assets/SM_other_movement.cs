using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM_other_movement : MonoBehaviour {

	// Use this for initialization
	Vector3 position;
	Vector3 startpos;
	public Sprite cool,hot;
	 float prevtimescale;
	void Start () {
		position=new Vector3(Random.Range(-10,-8),Random.Range(5,10),1);
		startpos=new Vector3(Random.Range(8,10),Random.Range(-10,-5),1);
		prevtimescale=Time.timeScale;
		transform.position=startpos;
		if(Time.timeScale<1){
			GetComponent<SpriteRenderer>().sprite=hot;
		}
	}
	
	// Update is called once per frame
	
	void Update () {
		transform.position=Vector3.MoveTowards(transform.position,position,Time.deltaTime*10);
		if(Vector2.Distance(new Vector2(position.x,position.y),transform.position)<2){
			Destroy(gameObject);
		}
		
		if(prevtimescale!=Time.timeScale){
			prevtimescale=Time.timeScale;
		if(prevtimescale==1){
			
			GetComponent<SpriteRenderer>().sprite=cool;

		}
		if(prevtimescale<1){
			
			GetComponent<SpriteRenderer>().sprite=hot;

		}
		}
	}
}
