﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkorScript : MonoBehaviour {
	private GUIStyle stail;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		stail = new GUIStyle(GUI.skin.label);
		stail.normal.textColor = Color.black;
		stail.fontSize = 30;
		GUI.Label(new Rect(Screen.width/2-120, Screen.height/2-80, 400, 40),"haiskoor: "+ PlayerPrefs.GetInt("haiskoor").ToString(), stail);
	}
}
