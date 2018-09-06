using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsCounter : MonoBehaviour {

	public GameObject player;
	public GameObject timerHolder;
	void Update () {
		GetComponent<Text>().text = player.GetComponent<Player_Controller_Demo>().powerupsCollected + "/" + (timerHolder.GetComponent<Timer>().maxTime/10);
	}
}
