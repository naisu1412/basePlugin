using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour {
	public GameObject slider;	
	public GameObject sliderCanvas;
	public void changeScene(int sceneIndex){
		
		sliderCanvas.SetActive(true);
		StartCoroutine(LoadAsync(sceneIndex));

	}


	IEnumerator LoadAsync(int sceneIndex){
		//sceneindex = index of the scene you want to load

		AsyncOperation operation =   SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
		
		while(!operation.isDone){
		
			float progress = Mathf.Clamp01(operation.progress / .9f);
			Debug.Log(progress);
			slider.GetComponent<Slider>().value = progress;
			yield return null;
		
		}

	} 
}
