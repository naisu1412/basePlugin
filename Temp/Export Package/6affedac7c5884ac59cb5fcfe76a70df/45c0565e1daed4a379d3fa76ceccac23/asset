using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Obstacle : MonoBehaviour {
public int damage;

public float speed;
public GameObject particleExplosion;
	GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player");
	}
	public void Update(){
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(player.GetComponent<Player_Controller_Demo>().SuperSaiyanMode == true){

			

			}else{
			
				col.GetComponent<Player_Controller_Demo>().healthPlayer -= damage;
				
				
		
			}
		
			explosionInstatiate();
			Destroy(gameObject);
		
		 	 
		 }
	}

		void explosionInstatiate(){
		GameObject 	particleTEMP =  Instantiate(particleExplosion,transform.position,Quaternion.identity);
			Destroy(particleTEMP,1);	
	}
}
