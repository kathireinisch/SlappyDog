using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	private bool isPaused = false;
	private Rect butRect;

	// Use this for initialization
	void OnGUI () {
		if(isPaused){
			if(Input.GetButtonDown("ResumeBt")){
				ToggleTimeScale ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("PauseBt")){
			ToggleTimeScale ();
		}
	}

	void ToggleTimeScale(){
		if (!isPaused) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
		isPaused = !isPaused;
	}
}
