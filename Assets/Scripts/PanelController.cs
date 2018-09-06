using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PanelController : MonoBehaviour {
		/* 

			A script to use as a panel controller for the list of pages. Only works for next and previous.

		*/
	public GameObject[] panels;
	public UnityEvent startGame;


	public void panelSwitch(int index){

		if(index+1 != panels.Length ){
		
			panels[index].SetActive(false);
			panels[index+1].SetActive(true);
		
		}else{
		
			if(startGame != null){
		
				startGame.Invoke();

			}
		}
	}
}
