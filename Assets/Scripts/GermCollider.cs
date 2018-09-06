using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GermCollider : MonoBehaviour {

	public GameObject particleSystem;
	public Sprite spriteNormal;
	public Sprite spriteSuper;
	


	void Start () {
		if( gameObject.tag == "Germ" ){
	
			gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = spriteNormal;
	
		}else{

			gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = spriteSuper;
		
		}
		Debug.Log(" Game Start ");
	}

	void OnTriggerEnter2D(Collider2D capsule) {
        
		if(capsule.tag == "capsule"){
			if( gameObject.tag == "Germ" ){

			Debug.Log(" Germ Hit ");
			gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().material.color = new Color(0,0,0,0);
			Destroy(gameObject , .1f);
			GameObject goParticleSystem =  Instantiate(particleSystem, gameObject.transform.position,Quaternion.identity);
			Destroy(goParticleSystem , goParticleSystem.GetComponent<ParticleSystem>().main.duration);

			}else if(gameObject.tag == "superGerm"){
				gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = spriteNormal;
				gameObject.tag = "Germ";

			}
		}

    }
}
