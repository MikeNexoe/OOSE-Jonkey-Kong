using UnityEngine;
using System.Collections;

public class EndMenu : MonoBehaviour
{	
	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) 
		{
			Application.Quit ();
		}
	}
}