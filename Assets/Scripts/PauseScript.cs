using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour {
    public Button resume, mainMenu;
    public GameObject canvas;
    public bool gmeover = false;
	// Use this for initialization
	void Start () {
        resume.onClick.AddListener(onResume);
        mainMenu.onClick.AddListener(goback);

	}
	
	
    void onResume(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        if(gmeover){
            SceneManager.LoadScene("trial2");
        }
        canvas.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    void goback(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        SceneManager.LoadScene("Menu");
       
    }
}
