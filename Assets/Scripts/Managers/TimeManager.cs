//LMSC 281
//Augustus Rivera
//Survival Shooter
//Time Manager

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public static float timer;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent <Text> ();
		timer = 20f;
		
	}

	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		text.text = "Timer: " + Mathf.RoundToInt(timer);


	}
}
