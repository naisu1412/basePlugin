using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Timer : MonoBehaviour {
	/* */
	public Text timerText; //text ui in the game
	public int maxTime = 0;	//when will the timer stop
	public float timeScaleValue = 1;	// !! Use as a modifier for the timescale, remove if not needed !!	

	[HideInInspector]
	public int timer;
	public UnityEvent eventController;	// event to run 
	float runEventEvery = 10;	//when will the event run 

	int timeDecrementValue = 1; // at what amount will the time decrease
	void Start(){
		timer = maxTime-1;
		StartCoroutine("timerDecrement");
	}	
	void Update () {
		timerText.text = ((int)timer).ToString();
		
			if(timer<0){
				
				
			}
		
		}
	

	IEnumerator timerDecrement(){
	if(timer>0){
		yield return new WaitForSeconds(1);
		timer -= timeDecrementValue;
		if(timer % runEventEvery == 0 ){	
			eventController.Invoke();
		}
		StartCoroutine("timerDecrement");
	}

	}
}

