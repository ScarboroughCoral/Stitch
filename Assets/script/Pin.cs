 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {


	private bool isFlay = false;
	private bool isArrived = false;
	private Transform originalPosition;//开始位置

	private Transform target;

	private Vector3 targetCirclePosition;


	// Use this for initialization
	void Start () {
		
		originalPosition = GameObject.Find("OriginalPosition").transform;
		target = GameObject.Find("Target").transform;
		targetCirclePosition = target.position;
		targetCirclePosition.y -=1.8f;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFlay==false)
		{
			if (isArrived==false)
			{
				transform.position=Vector3.MoveTowards(transform.position,originalPosition.position,2*Time.deltaTime);
				if (Vector3.Distance(transform.position,originalPosition.position)<0.05f)
				{
					isArrived = true;
				}
			}
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position,targetCirclePosition,100*Time.deltaTime);
			if (Vector3.Distance(transform.position,targetCirclePosition)<0.05f)
			{
				transform.position = targetCirclePosition;
				transform.parent = target;
				
				isFlay = false;
			}
		}
	}


	public void Start_Fly(){
		isFlay = true;
		isArrived = true;
	}
}
