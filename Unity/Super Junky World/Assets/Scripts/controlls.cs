﻿using UnityEngine;
using System.Collections;

public class controlls : MonoBehaviour {

	void OnGUI () {
		// Make a background box

		GUI.Box(new Rect(10,20,300,100), "Press a for left");
		GUI.Box(new Rect(10,40,300,100), "Press d for right");
		GUI.Box(new Rect(10,60,300,100), "Press space for jump");
		GUI.Box(new Rect(10,80,300,100), "Press ctrl for shrink");
		GUI.Box(new Rect(10,100,300,100), "Press m for Menu"); {
		if (Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel("Menu"); }

		}

	
	}
}
