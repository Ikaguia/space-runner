﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public GameObject player;

	// Update is called once per frame
	void Update() {
		transform.position = new Vector3 (player.transform.position.x, transform.position.y, -10f);
	}
}
