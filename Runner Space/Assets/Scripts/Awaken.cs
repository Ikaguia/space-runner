﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awaken : MonoBehaviour{
	public Collider2D player;
	public GameObject target;

	// OnTriggerEnter2D is called when a trigger starts
	void OnTriggerEnter2D(Collider2D col) {
		if(col == player){
			target.SetActive(true);
		}
	}
}
