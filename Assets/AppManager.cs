using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour {
    public static AppManager instance;
   public AudioSource audioSource;
    void Awake()
    {

        // check if there is already a gamemanager in the scene
        if (instance == null)
        {
            instance = this;


        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);

	}
	
	// Update is called once per frame
	public void btClick () {
        audioSource.Play();
	}
}
