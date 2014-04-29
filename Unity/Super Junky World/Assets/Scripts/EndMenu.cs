using UnityEngine;
using System.Collections;

public class EndMenu : MonoBehaviour 
{	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Q))
			Application.Quit();	
	}
	
	void OnGUI () 
	{
		GUI.Box(new Rect(10,10,100,90), "End score: ");
	}
}
