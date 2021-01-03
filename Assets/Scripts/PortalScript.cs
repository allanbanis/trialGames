using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {
    public GameObject exit_portal;

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag=="Player"){
            Vector3 temp = exit_portal.transform.position;
            Destroy(exit_portal);
            Destroy(gameObject);
            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x,temp.y,collision.gameObject.transform.position.z);
        }
	}
}
