using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	// Update is called once per frame
	void Update() {
		float speed = Hero.speed;
		Debug.Log(speed);
		transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;
		// transform.Translate(new Vector3(speed * Time.deltaTime, 0f, 0f));
	}
}
