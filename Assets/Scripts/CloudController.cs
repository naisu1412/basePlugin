using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;

public class CloudController : MonoBehaviour {
	public GameObject cloudOBJ;
	public GameObject parentOBJ;
	GameObject objCloudToDestroy;
	public GameObject buttonNext;
	 

	public void cloudInstantiate(){
	
	
			if(objCloudToDestroy){
				Destroy(objCloudToDestroy);
			}
				objCloudToDestroy =  Instantiate(cloudOBJ,parent: parentOBJ.transform);
				objCloudToDestroy.GetComponent<Animator>().Play("cloudAnim");	
				buttonNext.SetActive(true);
	
		
	
	}


	void Update(){

	}
}
