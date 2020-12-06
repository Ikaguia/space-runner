using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour{
	public Collider2D playerCol;
	public GameObject player;
	public GameObject fadeOut;
	public GameObject win;

	// OnTriggerEnter2D is called when a trigger starts
	void OnTriggerEnter2D(Collider2D col) {
		if(col == playerCol){
			fadeOut.SetActive(true);
			win.SetActive(true);
			player.SetActive(false);
		}
	}
}
