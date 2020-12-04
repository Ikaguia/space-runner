using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {
	public Collider2D player;
	public GameObject fadeOut;
	public GameObject loss;

	// OnTriggerEnter2D is called when a trigger starts
	void OnTriggerEnter2D(Collider2D col) {
		if(col == player){
			 // Application.Quit();
			fadeOut.SetActive(true);
			loss.SetActive(true);
		}
	}
}
