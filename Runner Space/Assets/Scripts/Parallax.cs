using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
	public GameObject player;
	public float parallaxScaleX;
	public float parallaxScaleY;

	private float offsetX;
	private float offsetY;

	// Start is called before the first frame update
	void Start() {
		offsetX = transform.position.x;
		offsetY = transform.position.y;
	}

	// Update is called once per frame
	void Update() {
		transform.position = new Vector3(player.transform.position.x * parallaxScaleX + offsetX, player.transform.position.y * parallaxScaleY + offsetY, transform.position.z);
	}
}
