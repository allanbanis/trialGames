using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortals : MonoBehaviour {
    public GameObject portalPrefab;
    float timer = 0, limit = 0;
    float Speed = 10f;
    Stack<GameObject> portals = new Stack<GameObject>();
	// Use this for initialization
	void Start () {
        limit = Random.Range(5, 7);
	}
	
	// Update is called once per frame
	void Update () {
        if(GetComponent<GameManager>().gameOver){
            return;
        }
        timer += Time.deltaTime;
        if(timer>limit){
            limit = Random.Range(7, 12);
            timer = 0;
            GameObject p1, p2;
            p1 = Instantiate(portalPrefab);
            p2 = Instantiate(portalPrefab);
            p1.GetComponent<PortalScript>().exit_portal = p2;
            p2.GetComponent<PortalScript>().exit_portal = p1;
            p1.transform.position = new Vector3(17.5f, 3.87f, -1f);
            p2.transform.position = new Vector3(17.5f, -1.79f, -1f);
            portals.Push(p1);
            portals.Push(p2);
        }
        Stack<GameObject> temp = new Stack<GameObject>();
        foreach (GameObject obj in portals)
        {
            bool skip = false;

            if(obj==null){
                skip = true;
            }else{
                obj.transform.position += Vector3.left * Time.deltaTime * Speed;
          
            if (obj.transform.position.x < -17.6f && !skip)
            {
                skip = true;
                Destroy(obj);
                }}
            
            if(!skip){
                temp.Push(obj);
            }
        }
	}
}
