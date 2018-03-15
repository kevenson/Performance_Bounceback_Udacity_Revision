using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
	private Text text;
	private int previousScore;
	//public Trampoline trampoline;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		text = GetComponentInChildren<Text>();
		previousScore = 0;
	}

	void updateScore() {
		text.text = "Score: " + gameManager.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		// move this to Start
       // Text text = GetComponentInChildren<Text>();
		if (previousScore < gameManager.score) {
			text.text = "Score: " + gameManager.score.ToString ();
			previousScore = gameManager.score;
		}
		
	}
}
