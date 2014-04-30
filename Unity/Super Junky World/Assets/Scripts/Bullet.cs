using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position -= new Vector3 (0.75f, -0.4f, 0.85f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0.15f, 0, 0);
	}

	void OnCollisionEnter(Collision other)
	{
		//if (other.gameObject.name == "Junky") 
			Destroy (gameObject);
	}
}
