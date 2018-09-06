using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

	public float speed;
	public float endX;
	public float startX;

	void Update(){
		transform.Translate(Vector2.left * speed * Time.deltaTime);

//		Debug.Log(transform.localPosition.x + " " + endX);
		if(transform.localPosition.x <= endX){
			Vector2 pos = new Vector2(startX, transform.localPosition.y);
			transform.localPosition = pos;
		}
	}
}
