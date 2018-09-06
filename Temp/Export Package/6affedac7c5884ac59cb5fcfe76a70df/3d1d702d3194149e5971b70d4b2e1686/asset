using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoueText : MonoBehaviour {
    /* 
        Use for dialogue and texts.
    */
    public TextMeshProUGUI textDisplay; 
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject buttonNext;
    void Start(){
        StartCoroutine( Type() );
    }
    IEnumerator Type(){
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
          
        }

          buttonNext.SetActive(true);
    }
}
