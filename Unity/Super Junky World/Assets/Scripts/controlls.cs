using UnityEngine;
using System.Collections;

public class controlls : MonoBehaviour {

	void OnGUI () {
		// Make a background box

		GUI.Box(new Rect(10,20,300,100), "Press A for left");
		GUI.Box(new Rect(10,40,300,100), "Press D for right");
		GUI.Box(new Rect(10,60,300,100), "Press space to jump");
		GUI.Box(new Rect(10,80,300,100), "Press ctrl to duck");
		GUI.Box(new Rect(10,100,300,100), "Press M for Mmnu");
		GUI.Box(new Rect(10,120,300,100), "Press ESC to exit game"); {
			
		if (Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel("Menu"); }

		}

	
	}
}
