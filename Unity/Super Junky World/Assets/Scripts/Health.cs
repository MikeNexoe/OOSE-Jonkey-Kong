using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;

	// Use this for initialization
	void Start () 
	{
		health = 3.0f;
	}

	void Update () 
	{
		if (health == 0) 
		{
		Application.LoadLevel("EndMenu");
		
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect(100, 10, 70, 20), "Health: " + health.ToString("0"));
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Enemy") 
			health -= 1.0f;
	}
}
