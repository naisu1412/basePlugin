using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class Player_Controller_Demo : MonoBehaviour {


	Vector2 targetPos;
	public float YIncrement;
	public Animator AnimationPlay;
	public float speed;

	public float maxHeight;
	public float minHeight;
	public GameObject hpBar;
	public bool SuperSaiyanMode = false; 	//supersaiyan mode

	public int MaxHealth = 5;
	[HideInInspector]
	public int healthPlayer;
	public GameObject particles;
	public Sprite[] babyStates;
	public int powerupsCollected = 0;
	public GameObject superSaiyanGlow;
	public GameObject superSaiyanGlow2;
	public GameObject classCollection;
	public Vector3 allowedVerticalLocation;
	GameObject audio;
	void Reset(){
		
		targetPos = transform.position;
	}
	void Start () {
		audio = GameObject.FindGameObjectWithTag("Audio");
		healthPlayer = MaxHealth;
		Reset();
		
	}
	public void GameOver(){
		classCollection.GetComponent<CheckpointController>().trianglePanel.SetActive(false);
		classCollection.GetComponent<CheckpointController>().successPanel.SetActive(false);
		classCollection.GetComponent<CheckpointController>().gameoverPanel.SetActive(true);
		classCollection.GetComponent<CheckpointController>().checkpointParentInfoHolder.SetActive(true);

	}


	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public GameObject panelPause;
	public GameObject checkPoint;

	// Update is called once per frame
	void Update () {

		if(panelPause.activeInHierarchy == true || checkPoint.activeInHierarchy == true){

		}else{
					if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
					{
					RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint((Input.GetTouch (0).position)), Vector2.zero);
					if(hit.collider != null)
					{
							if(hit.transform.tag == "LeftPanel"){
								GoUp();
							}else if (hit.transform.tag == "RightPanel"){
								GoDown();
							}
					
					}
					}
		}



	
   

		if(SuperSaiyanMode == true){
				gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = babyStates[3];
				hpBar.transform.GetChild(0).gameObject.SetActive(true);
				hpBar.transform.GetChild(1).gameObject.SetActive(true);
				hpBar.transform.GetChild(2).gameObject.SetActive(true);
				superSaiyanGlow.SetActive(true);	
				superSaiyanGlow2.SetActive(true);	

		}else{
			superSaiyanGlow.SetActive(false);	
			superSaiyanGlow2.SetActive(false);	

			switch (healthPlayer)
			{
				case 3:
					gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = babyStates[0];
					hpBar.transform.GetChild(0).gameObject.SetActive(true);
					hpBar.transform.GetChild(1).gameObject.SetActive(true);
					hpBar.transform.GetChild(2).gameObject.SetActive(true);
					break;
				
				case 2:
					gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = babyStates[1];
					hpBar.transform.GetChild(0).gameObject.SetActive(true);
					hpBar.transform.GetChild(1).gameObject.SetActive(true);
					hpBar.transform.GetChild(2).gameObject.SetActive(false);
					break;
				
				case 1:
					gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = babyStates[2];
					hpBar.transform.GetChild(0).gameObject.SetActive(true);
					hpBar.transform.GetChild(1).gameObject.SetActive(false);
					hpBar.transform.GetChild(2).gameObject.SetActive(false);
					break;
				default:
				break;
			}
		}
	


		if(healthPlayer <= 0){
		//	Debug.Log("Game Over......");
			GameOver();
		}

	
		//Debug.Log(transform.position);
		transform.position = Vector2.MoveTowards(transform.position,targetPos,speed * Time.deltaTime);

		//to add a boundary
		if(transform.position.y > maxHeight){
			transform.position = new Vector2(transform.position.x,maxHeight);
		}

 
		//to add a boundary		
		if(transform.position.y < minHeight){
			transform.position = new Vector2(transform.position.x,minHeight);
		}



		if(Input.GetKeyDown(KeyCode.UpArrow)	){
			GoUp();
		}
		
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			GoDown();
		}
		
	}

	void explosionInstatiate(){
			GameObject 	particleTEMP =  Instantiate(particles,transform.position,Quaternion.identity);
			
			Destroy(particleTEMP,1);

			
	}

	IEnumerator RebindAnim(){
		yield return new WaitForSeconds(1);
		AnimationPlay.Rebind();
	}
	
	public void GoUp(){

  	

	string verticalPosition = gameObject.transform.position.y.ToString("1F");	

	if( verticalPosition == allowedVerticalLocation.x.ToString() || verticalPosition == allowedVerticalLocation.y.ToString() || verticalPosition == allowedVerticalLocation.z.ToString()){

	}else{
			explosionInstatiate();
			targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
	}
		audio.GetComponent<audioController>().PlaySound(1);
	
	}


	public void GoDown(){
	
	string verticalPosition = gameObject.transform.position.y.ToString("1F");
	
	if( verticalPosition == allowedVerticalLocation.x.ToString() || verticalPosition == allowedVerticalLocation.y.ToString() || verticalPosition == allowedVerticalLocation.z.ToString()){

	}else{
		explosionInstatiate();
			targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement);	
	}
			audio.GetComponent<audioController>().PlaySound(1);	
	}
}
