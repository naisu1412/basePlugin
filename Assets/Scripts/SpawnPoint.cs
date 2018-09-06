using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

	public GameObject obstacle;
	public GameObject parent;
	void Start(){
		parent = GameObject.FindGameObjectWithTag("ParentCows");
		Instantiate(obstacle, transform.position,Quaternion.identity,parent.transform);
	}
}
