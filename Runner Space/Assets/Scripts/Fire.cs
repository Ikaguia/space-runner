using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	private Rigidbody2D rb; //componente rigid body

	// Start is called before the first frame update
	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		float speed = Hero.speed;
		Debug.Log(speed);
		rb.velocity = new Vector3(speed, 0f, 0f);
	}
}
