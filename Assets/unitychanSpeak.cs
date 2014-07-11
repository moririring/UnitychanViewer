using UnityEngine;
using System.Collections;

public class unitychanSpeak : MonoBehaviour {

	public AudioClip selectSound;

	// Use this for initialization
	void Start () {
		audio.clip = selectSound;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")){
			audio.Play();
		} 
	}
}
