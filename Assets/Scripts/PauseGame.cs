using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {
	public Transform pausemenu;

	// Update is called once per frame
	void Update () {
		//if(Input.GetButtonDown("PauseBT")){
		if(Input.GetKeyDown(KeyCode.Escape)){
			if (pausemenu.gameObject.activeInHierarchy == false) {
				pausemenu.gameObject.SetActive (true);
				Time.timeScale = 0;

			} else {
				pausemenu.gameObject.SetActive (false);
				Time.timeScale = 1;

			}
		}
	}
}
