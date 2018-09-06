using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour {
    // Your audio clip
    public AudioClip[] MusicClip;

    // the component that Unity uses to play your clip
    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    public void PlaySound(int index){
    for(int i = 0; i<MusicClip.Length;i++){
        if(index == i){
            MusicSource.clip = MusicClip[i];
        }
    }

        MusicSource.Play();
        Debug.Log("Play");
    }


}
