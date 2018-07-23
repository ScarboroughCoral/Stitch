using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin_Circle : MonoBehaviour {

	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag=="pin_circle")
		{
			GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
		}
	}
}
