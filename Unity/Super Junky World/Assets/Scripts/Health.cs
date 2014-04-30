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
		if (health <= 0) 
		{
		Application.LoadLevel("EndMenu");	
		}
	}

	void OnGUI()
	{
		if (Application.loadedLevelName != "EndMenu") 
		{
			GUI.Box (new Rect (100, 10, 70, 20), "Health: " + health.ToString ("0"));
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "EnemyJ") 
			health -= 1.0f;
		if (other.gameObject.name == "EnemyNJ") 
			health -= 1.0f;
		if (other.gameObject.name == "EnemyCop") 
			health -= 1.0f;
		if (other.gameObject.name == "Bullet") 
			health -= 1.0f;
	}
}
