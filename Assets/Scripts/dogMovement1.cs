using UnityEngine;
using System.Collections;

public class dogMovement1 : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public Vector3 gravity; 
	public Vector3 flapVelocity;
	public float maxSpeed = 5f;
	public float forwardSpeed = 50f;
	public bool dead = false;
	bool didFlap = false;
	float deathCooldown = 0.5f;
	Animator animator;
	public bool trigger = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	void Update (){
		if (dead) {
			deathCooldown -= Time.deltaTime;
			if (deathCooldown <= 0) {
				if (Input.GetMouseButtonDown (0)) {
					Application.LoadLevel (Application.loadedLevel);
				}
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				animator.SetTrigger ("DoFlap");
				didFlap = true;
			}
		}
		trigger = false;
	}


	// Update is called once per frame
	void FixedUpdate () {
		if(dead == false){
			velocity += gravity;// * Time.fixedDeltaTime;
			velocity.x = forwardSpeed;

			if(didFlap == true){
			
				didFlap = false;

				if (velocity.y < 0) {
					velocity.y = 0;
				}

				velocity += flapVelocity;
			}

			velocity = new Vector3 (Mathf.Clamp (velocity.x, 0, maxSpeed), velocity.y, 0);
			//velocity = Vector3.ClampMagnitude (velocity, maxSpeed);
			transform.position += velocity * Time.fixedDeltaTime;
			Debug.Log (velocity + "   " + velocity * Time.fixedDeltaTime);
		}

	}

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("HIT SOMETHING COLLISION");
		animator.SetTrigger ("Death");
		forwardSpeed = 0f;
		dead = true;
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("HIT SOMETHING TRIGGER");
		trigger = true;


	}

	private Rigidbody2D body;
	void Awake(){
		body = GetComponent<Rigidbody2D> ();
	}
}
