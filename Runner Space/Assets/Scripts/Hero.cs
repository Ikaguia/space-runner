using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
	private Rigidbody2D rb; //componente rigid body
	private SpriteRenderer sr; //componente sprite renderer
	private bool upsideDown = false;
	private bool chao = false;

	static private float forP = 100f; //forca do pulo
	static private float forMJ = 10f; //forca da mochila a jato

	static public float speed = 5f; //velocidade horizontal


	// Start is called before the first frame update
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();
		CalculateGravity();
	}

	// OnTriggerEnter2D is called when a trigger starts
	void OnTriggerEnter2D(Collider2D col) {
		chao = true;
	}

	// OnTriggerEnter2D is called when a trigger ends
	void OnTriggerExit2D(Collider2D col) {
		chao = false;
	}

	// Update is called once per frame
	void FixedUpdate() {
		CalculateGravity();

		rb.velocity = new Vector2(speed, rb.velocity.y);
		if(Input.GetButton("Jump")) rb.AddForce(Vector2.up * (chao ? forP : forMJ) * (upsideDown ? -1 : 1));
	}


	// Calculates gravity based on vertical position
	void CalculateGravity() {
		float y = rb.position.y;
		Physics2D.gravity = new Vector2 (0, 2 * Mathf.Min(y, 5f));
		upsideDown = y > 0;
		transform.localScale = new Vector2 (transform.localScale.x, Mathf.Clamp(y, -1f, 1f) * -1);
	}
}
