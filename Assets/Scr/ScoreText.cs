using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
    Text scoreText;
	void Start () {
        scoreText = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = "qula: " + GlobalParams.score.ToString();
	
	}
}
