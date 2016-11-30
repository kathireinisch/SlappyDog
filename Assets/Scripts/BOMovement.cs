using UnityEngine;
using System.Collections;

public class BOMovement : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	float speed = -3f;
	public Transform boost;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void fixedUpdate(){
		Debug.Log ("..");
		velocity.x = speed;
		transform.position += velocity * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider collider){
		boost.gameObject.SetActive(false);	}
}
