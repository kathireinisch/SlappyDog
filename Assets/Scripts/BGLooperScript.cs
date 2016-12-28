using UnityEngine;
using System.Collections;

public class BGLooperScript : MonoBehaviour {

	int numBGPanels = 2;
	float maxYPos = 2.5f;
	float minYPos = -1.65f;

	void OnTriggerEnter2D (Collider2D collider){
		float widthOfBGObject = 6.4f;
		Vector3 pos = collider.transform.position;
		pos.x += widthOfBGObject * numBGPanels;
		if (collider.tag == "Boost") {
			pos.y = Random.Range (minYPos, maxYPos);
		}
		collider.transform.position = pos;
	}
}
