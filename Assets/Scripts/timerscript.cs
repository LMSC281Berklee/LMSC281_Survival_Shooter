using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour {

	public int timer;
	Text text;
	private float timedown;
	private float countdown;
	private float ftimer;


	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		ftimer = 2000;

		
	}
	
	// Update is called once per frame
	void Update () {
		timedown = Time.deltaTime;
		countdown = ftimer - timedown;
		timer = Mathf.RoundToInt(countdown);
		text.text = timer.ToString() ;
	}
}
