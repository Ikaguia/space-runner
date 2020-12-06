using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {
	public Collider2D playerCol;
	public GameObject player;
	public GameObject fadeOut;
	public GameObject loss;

	// OnTriggerEnter2D is called when a trigger starts
	void OnTriggerEnter2D(Collider2D col) {
		if(col == playerCol){
			 // Application.Quit();
			fadeOut.SetActive(true);
			loss.SetActive(true);
			player.SetActive(false);
		}
	}
}
