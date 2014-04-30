using UnityEngine;
using System.Collections;

public class LevelChange2 : MonoBehaviour {
	
	void OnCollisionEnter(Collision LevelChange) 
	{
		if(LevelChange.gameObject.name == "Junky") 
			Application.LoadLevel("EndMenu");
	}
}