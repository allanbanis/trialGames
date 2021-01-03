using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikes : MonoBehaviour {
   public GameObject spikePrefab;
    float timer = 0, limit = 0;
    float Speed = 10f;
    Stack<GameObject> spikes = new Stack<GameObject>();
	// Use this for initialization
	void Start () {
        limit = Random.Range(1, 2);
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.Find("GameManager").GetComponent<GameManager>().gameOver){
            return;
        }
        timer += Time.deltaTime;
        if(timer>limit){
            limit = Random.Range(1, 5);
            timer = 0;
            GameObject obj = Instantiate(spikePrefab);
            obj.transform.position = new Vector3(17.5f, 1.490354f, 1);
            obj.transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(7, 11), 1);
            spikes.Push(obj);
        }
        Stack<GameObject> temp = new Stack<GameObject>();
        foreach (GameObject ob in spikes)
        {
            bool skip = false;
            ob.transform.position += Vector3.left * Time.deltaTime * Speed;

            if (ob.transform.position.x < -17.6f)
            {
                skip = true;
                Destroy(ob);
            }
            if(!skip){
                temp.Push(ob);
            }
        }
        spikes = temp;
	}
	private void OnCollisionEnter(Collision collision)
	{
		
	}
}
