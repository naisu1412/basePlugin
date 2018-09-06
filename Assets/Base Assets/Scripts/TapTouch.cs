using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TapTouch : MonoBehaviour {
	/*
		Touch event for Mobile Devices
	 */
	public UnityEvent tapped;

	void Update(){
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
			tapped.Invoke();
        }
	}
}
