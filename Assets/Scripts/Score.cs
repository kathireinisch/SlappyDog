using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	static public float score = 0;
	static public float highscore = 0;
	dogMovement1 dog;
	static Score instance;

	private Text text;



	void Start(){
		instance = this;
		text = GetComponent<Text> ();
		GameObject playerGO = GameObject.FindGameObjectWithTag ("Player");
		dog = playerGO.GetComponent<dogMovement1> ();
		score = 0;
		highscore = PlayerPrefs.GetFloat ("Highscore: ", 0);
	}

	static public void AddPoint(){
		if (instance.dog.dead) {
			return;
		} else {
			score = score + 0.01f;
			score = Mathf.Round (score * 100)/100;
			GameObject boostGO = GameObject.FindGameObjectWithTag ("Boost");
			if(instance.dog.trigger){
				score = score + 10f;
				boostGO.SetActive (false);

			}
			if(highscore<score){
				highscore = score;
			}
		}
	}
		

	void OnDestroy () {
		instance = null;
		PlayerPrefs.SetFloat ("Highscore: ", highscore);
	}
	
	void Update () {
		text.text = "Score: " + score + "   Highscore: " + highscore;
		AddPoint ();
	}
}
