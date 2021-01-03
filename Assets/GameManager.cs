using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public GameObject[] sprites;
    public float Speed=10f;
    public bool gameOver = false;
    public GameObject deadObject;
    public Text scoreText;
    float score = 0;
    float gameovertimer = 3f;
    public GameObject gmeOvrCanvas, Canvas, PauseCanvas;

	// Use this for initialization
	private void Start()
	{
        Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update () {
        if (!gameOver)
        {
            score += Time.deltaTime*2;
            scoreText.text = ""+(int)(score);
            foreach (GameObject obj in sprites)
            {
                obj.transform.position += Vector3.left * Time.deltaTime * Speed;
                if (obj.transform.position.x < -17.6f)
                {
                    obj.transform.position = new Vector2(17f * 2, 1.1f);

                }
            }
        }else{
            gameovertimer -= Time.deltaTime;
            if(gameovertimer<0){
                gmeOvrCanvas.SetActive(true);
                PauseCanvas.SetActive(false);
                Canvas.SetActive(false);
            }
        }
        //else { Time.timeScale =0; }
	}
}
