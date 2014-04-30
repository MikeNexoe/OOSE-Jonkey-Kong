using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {
	
	void OnCollisionEnter(Collision LevelChange) 
	{
		if(LevelChange.gameObject.name == "Junky") 
			Application.LoadLevel("Scene02");
	}
}