using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {
    public GameObject[] enemyArray;
    float timer = 0;
    float limit = 0;
    // Use this for initialization
	void Start () {
        limit = Random.Range(4, 5);

	}
	
	// Update is called once per frame
	void Update () {
        if(GetComponent<GameManager>().gameOver){
            return;
        }

           timer += Time.deltaTime;
        if (timer > limit)
        {
            timer = 0;
            limit = Random.Range(1, 5);
            int i = Random.Range(0, enemyArray.Length);
            if(i==0){
                spawnBomb();
            }
            if(i==1){
                spawnOwl();
            }
            if(i==2||i==3){
                spawnSpiders();
            }
        }
       
       

	}
    //-3.6f
    void spawnBomb(){
        int temp = Random.Range(-1, 1);
        if (temp < 0)
        {
            //spawn down
            GameObject bomb = Instantiate(enemyArray[0]);
            bomb.transform.position = new Vector3(17.6f, -3.6f, -1f);
        
        }else{
            GameObject bomb = Instantiate(enemyArray[0]);
            bomb.transform.position = new Vector3(17.6f, 2, -1f);
        
        }
        
    }
    void spawnOwl(){
        int temp = Random.Range(-1, 1);
        if (temp < 0)
        {
            //spawn down
            GameObject bomb = Instantiate(enemyArray[1]);
            bomb.transform.position = new Vector3(17.6f, -3f, -1f);

        }
        else
        {
            GameObject bomb = Instantiate(enemyArray[1]);
            bomb.transform.position = new Vector3(17.6f, 2, -1f);

        }
    }
    void spawnSpiders(){
        GameObject web = Instantiate(enemyArray[3]);
        web.transform.position = new Vector3(17.6f, 3.03f, -1f);
       
        GameObject bomb = Instantiate(enemyArray[2]);
        bomb.transform.position = new Vector3(17.6f, -1.7f, -1f);
        bomb.GetComponent<SpiderScript>().web = web;
    }
}
