﻿using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Menu");

		// Make the first button. If it is pressed, Application.Start (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Start")) {
			Application.LoadLevel("Scene01");
		}

		// Make the second button.
		if (GUI.Button(new Rect(20,70,80,20), "Controls")) {
			Application.LoadLevel("controlls");
		}
	}
}
