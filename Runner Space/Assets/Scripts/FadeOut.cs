using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour{
	private SpriteRenderer sr; //componente sprite renderer

	public float time;

	// Start is called before the first frame update
	void Start(){
		sr = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update(){
		sr.color = new Color(0f, 0f, 0f, Mathf.Clamp01(sr.color.a + (Time.deltaTime / time)));
	}
}
