using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToCapsule : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		 transform.GetComponent<Rigidbody2D>().AddForce(transform.up * 100 * Time.deltaTime);
		 transform.GetComponent<Rigidbody2D>().AddForce(transform.right * 100 * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
