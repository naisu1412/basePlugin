using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeBlinking : MonoBehaviour {

	public Sprite openEyes;
	public Sprite closeEyes;
	public GameObject cloudControl;

	void Update(){
	
	}

	void Awake(){
		startEyeAnim();
	}


	public void startEyeAnim(){
		StartCoroutine("cEyeAnim");

	}

	IEnumerator cEyeAnim(){

		Image babyEyes = gameObject.GetComponent<Image>();
		
		yield return new WaitForSeconds(.1f);
		babyEyes.sprite = openEyes;
		
		yield return new WaitForSeconds(1f);
		babyEyes.sprite = closeEyes;

		yield return new WaitForSeconds(.3f);
		babyEyes.sprite = openEyes;

		yield return new WaitForSeconds(.3f);
		babyEyes.sprite = closeEyes;

		yield return new WaitForSeconds(.1f);
		babyEyes.sprite = openEyes;
		
		yield return new WaitForSeconds(.1f);
		babyEyes.sprite = closeEyes;
		
		yield return new WaitForSeconds(.2f);
		babyEyes.sprite = openEyes;
		
		yield return new WaitForSeconds(.6f);
		babyEyes.sprite = closeEyes;

		yield return new WaitForSeconds(1f);


		cloudControl.GetComponent<CloudController>().cloudInstantiate();


	}
}
