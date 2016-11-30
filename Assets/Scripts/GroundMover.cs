using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {

	Rigidbody2D player;

	void Start () {
		GameObject playerGo = GameObject.FindGameObjectWithTag ("Player");
		if(playerGo == null){
			Debug.LogError("Couldn't find player");
			return;
		}
		player = playerGo.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		float vel = player.velocity.x * 0.1f;
		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
	}
}
