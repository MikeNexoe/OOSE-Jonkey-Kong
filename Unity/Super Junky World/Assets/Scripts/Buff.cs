using UnityEngine;
using System.Collections;

public class Buff : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Junky") 
			Destroy (gameObject);
	}
}
