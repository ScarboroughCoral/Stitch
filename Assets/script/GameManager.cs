using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private Transform BeforePosition;//预热位置

	public GameObject pinPrefab;//针的预制体
	public GameObject scoreText;
	private Pin pin;

	private bool isGameOver = false;
	private int score = 0;
	// Use this for initialization
	void Start () {
		BeforePosition = GameObject.Find("BeforePosition").transform;
		init_pin();
	}
	
	// Update is called once per frame
	void Update () {

		scoreText.GetComponent<Text>().text =score.ToString();
		if (isGameOver)
			{
				return;
			}
		if (Input.GetMouseButtonDown(0))
		{
			
			pin.Start_Fly();
			init_pin();
			score++;
			

		}

		
	}

	void init_pin(){
		pin = GameObject.Instantiate(pinPrefab,BeforePosition.position,pinPrefab.transform.rotation).GetComponent<Pin>();
	}

	public void GameOver(){
		if (isGameOver)
		{
			return;
		}
		
		score--;
		
		GameObject.Find("Target").GetComponent<Rotate>().enabled = false;
		isGameOver = true;
	}

	
}
