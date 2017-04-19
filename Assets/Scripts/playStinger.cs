using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playStinger : MonoBehaviour {

	public AudioSource myAudioSource1;
	public AudioSource myAudioSource2;
	public AudioSource myAudioSource3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play ();
	}

}


