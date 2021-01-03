using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HelpCanvasScript : MonoBehaviour {
    public GameObject canvas,htpcanvas,creditcanvas;
    public Button play, credite, htp, quit, htpback, creditback;

	// Use this for initialization
	void Start () {
        play.onClick.AddListener(onPlay);
        credite.onClick.AddListener(onCredit);
        htp.onClick.AddListener(onHtp);
        quit.onClick.AddListener(OnQuit);
        htpback.onClick.AddListener(onHtpBack);
        creditback.onClick.AddListener(onCreditBack);
        htpcanvas.SetActive(false);
        creditcanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void onPlay(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        SceneManager.LoadScene("trial2");
    }
    void onCredit(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        canvas.SetActive(false);
        htpcanvas.SetActive(false);
        creditcanvas.SetActive(true);
    }
    void onHtp(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        canvas.SetActive(false);
        htpcanvas.SetActive(true);
        creditcanvas.SetActive(false);
    }
	private void OnQuit()
    {GameObject.Find("AppManager").GetComponent<AppManager>().btClick();
        
        Application.Quit();
	}
    void onHtpBack(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        canvas.SetActive(true);
        htpcanvas.SetActive(false);
        creditcanvas.SetActive(false);
    }
    void onCreditBack(){
        GameObject.Find("AppManager").GetComponent<AppManager>().btClick();

        canvas.SetActive(true);
        htpcanvas.SetActive(false);
        creditcanvas.SetActive(false);
    }
}
