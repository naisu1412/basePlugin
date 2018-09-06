using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	

public class CheckpointController : MonoBehaviour {

	public GameObject checkpointParent;
	Vector2 checkpointStartPosition;
	public GameObject TimerHolder;
	public GameObject checkpointPanel;

	public GameObject checkpointSpeedRef;
	public Sprite[] checkpointInfo;
	public GameObject checkpointParentInfoHolder;
	public GameObject player;
	public GameObject trianglePanel;
	public GameObject successPanel;
	public GameObject gameoverPanel;
	public GameObject pausePanel;
	GameObject audio;

	void Start(){
		//audio = GameObject.FindGameObjectWithTag("Audio");
		audio = GameObject.FindGameObjectWithTag("AudioSaiyan");

		checkpointStartPosition = checkpointParent.transform.position;

		


	}
	bool checkpointTriggered = false;		//event triggered bool so that the checkpoint will appear one time exactly at 10 sec interval
	float speed;	//speed of the checkpoint
	int GameTimerInt;
	public void checkpointHide(){
		if( player.GetComponent<Player_Controller_Demo>().powerupsCollected == (int)TimerHolder.GetComponent<Timer>().maxTime/10 ){
						Debug.Log("Game Finish");
						checkpointParentInfoHolder.SetActive(true);
						trianglePanel.SetActive(false);
						successPanel.SetActive(true);
						gameoverPanel.SetActive(false);
						
		}else{
			checkpointParentInfoHolder.SetActive(false);
			trianglePanel.SetActive(true);
			successPanel.SetActive(false);
			gameoverPanel.SetActive(false);
			if(player.GetComponent<Player_Controller_Demo>().powerupsCollected != 0){
				checkpointParentInfoHolder.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = checkpointInfo[player.GetComponent<Player_Controller_Demo>().powerupsCollected];
	
			}


		}

		audio.GetComponent<audioController>().PlaySound(0);

	}
	void Update(){
			if(checkpointPanel.GetComponent<panelCheckpointCollide>().checkpointHit == true){
				checkpointParentInfoHolder.SetActive(true);
				checkpointPanel.GetComponent<panelCheckpointCollide>().checkpointHit = false;
			}

			if(checkpointParentInfoHolder.activeInHierarchy == true || pausePanel.activeInHierarchy == true){

				Time.timeScale = 0;

			}else{

				Time.timeScale = GetComponent<Timer>().timeScaleValue;

			}

			checkpointParent.transform.Translate(Vector2.left * checkpointSpeedRef.GetComponent<RepeatingBG>().speed * Time.deltaTime);
			GameTimerInt = (int)TimerHolder.GetComponent<Timer>().timer; 
			
			}
	public void timerDecrement(){
			checkpointParent.SetActive(true);	
			checkpointParent.transform.position = checkpointStartPosition;	
			checkpointPanel.GetComponent<Collider2D>().enabled = true; // collider2d will be activated	
			checkpointPanel.GetComponent<SpriteRenderer>().enabled = true; //spriteRenderer will be activated
			
			checkpointTriggered = true;
		

	}


	public void HidePanel(){
		pausePanel.SetActive(false);
	}



}
