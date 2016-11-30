﻿using UnityEngine;
using System.Collections;

public class CameraTraksPlayer : MonoBehaviour {

	Transform player;
	float offsetX;

	// Use this for initialization
	void Start () {
		GameObject playerGo = GameObject.FindGameObjectWithTag ("Player");
		if(playerGo == null){
			Debug.LogError("Couldn't find player");
			return;
		}
		player = playerGo.transform;
		offsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null){
			Vector3 pos = transform.transform.position;
			pos.x = player.position.x + offsetX;
			transform.position = pos;
		}
	}
}
