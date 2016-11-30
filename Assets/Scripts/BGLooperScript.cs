using UnityEngine;
using System.Collections;

public class BGLooperScript : MonoBehaviour {

	int numBGPanels = 2;
	float maxYPos = 2.5f;
	float minYPos = -1.65f;

	void OnTriggerEnter2D (Collider2D collider){
		Debug.Log ("Triggered:" + collider.name);
		float widthOfBGObject = 6.4f;
			//((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += widthOfBGObject * numBGPanels;
		if (collider.tag == "Boost") {
			Debug.Log ("Boost");
			pos.y = Random.Range (minYPos, maxYPos);
		}

		/*if (collider.tag == "Obstacle") {
			Debug.Log ("Obstacle");
			pos.y = Random.Range (minYPos, maxYPos);
		}*/

		collider.transform.position = pos;
	}
}
