using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
	public float speed;

	// Start is called before the first frame update
	void Start() {
		GetComponent<Rigidbody2D>().velocity = Vector2.Perpendicular(transform.up) * speed;	
	}
}
