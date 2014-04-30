using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0.15f, 0, 0);
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Junky") 
			Destroy (gameObject);
	}
}
