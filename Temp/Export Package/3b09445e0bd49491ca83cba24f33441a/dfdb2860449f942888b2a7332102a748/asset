using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Controller : MonoBehaviour {
	

	public float timeBtwSpawn;
	public float startSpawn;
	public float decreaseTime;
	public float minTime = .65f;
	public GameObject parent;
	public GameObject[] obstacePatterns;

	void Start(){
	}
	void Update () {

		if(timeBtwSpawn <= 0){
			int rand = Random.Range(0, obstacePatterns.Length);
			Instantiate(obstacePatterns[rand], transform.position, Quaternion.identity, parent.transform);
			destroyCows();
			timeBtwSpawn = startSpawn;
			if(startSpawn > minTime){
				startSpawn -= decreaseTime;
			}
		}
		else{
			timeBtwSpawn -= Time.deltaTime;
		}


		

	}


	void destroyCows(){
		if(parent.transform.childCount > 3){
			int maxCount = parent.transform.childCount;
			Destroy(parent.transform.GetChild(maxCount-1).gameObject,startSpawn+2);
			Destroy(parent.transform.GetChild(maxCount-2).gameObject,startSpawn+2);
			Destroy(parent.transform.GetChild(maxCount-3).gameObject,startSpawn+2);
		}

	}
}
