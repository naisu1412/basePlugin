using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelCheckpointCollide : MonoBehaviour {
	GameObject player;
	public GameObject particlePanel;
	public GameObject parent;
	public bool checkpointHit = false;
	void Start(){
		player = GameObject.FindGameObjectWithTag("Player");
	}

		IEnumerator superSaiyanModeOff(){
		yield return new WaitForSeconds(3);
		player.GetComponent<Player_Controller_Demo>().SuperSaiyanMode = false;	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "Player"){
			player.GetComponent<Player_Controller_Demo>().healthPlayer = player.GetComponent<Player_Controller_Demo>().MaxHealth;
			gameObject.GetComponent<SpriteRenderer>().enabled = false; 
			gameObject.GetComponent<Collider2D>().enabled = false;	//hides the object
			player.GetComponent<Player_Controller_Demo>().powerupsCollected +=1 ;
			Debug.Log(  player.GetComponent<Player_Controller_Demo>().powerupsCollected + " collected");
			GameObject 	particleTEMP =  Instantiate(particlePanel,new Vector3(transform.position.x,player.transform.position.y,transform.position.z),Quaternion.identity,parent.transform);
			Destroy(particleTEMP,1);


			player.GetComponent<Player_Controller_Demo>().SuperSaiyanMode = true;
			StartCoroutine("superSaiyanModeOff");
			checkpointHit = true;
		}
		
	}



}
