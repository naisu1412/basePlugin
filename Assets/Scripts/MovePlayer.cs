using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	/* This will also contain the vars for players */
	public float maxValLeft;
	public float maxValRight;
	void Start () {
		
	}
	
	public float playerSpeed = 1;
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			if(transform.localPosition.x > maxValLeft){
				transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
			}
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			if(transform.localPosition.x < maxValRight){	
				transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
			}
		}
	
	}
}
