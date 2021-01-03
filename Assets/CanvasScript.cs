using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasScript : MonoBehaviour {
    public Button pause;
    public Canvas pausecanvas;
	// Use this for initialization
	void Start () {
        pause.onClick.AddListener(onPause);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void onPause(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();
        Time.timeScale = 0;
        gameObject.SetActive(false);
        pausecanvas.gameObject.SetActive(true);
    }
}
