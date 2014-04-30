using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float timer;

	// Use this for initialization
	void Start () 
	{
		timer = 30.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Application.loadedLevelName != "EndMenu") 
		{
			timer -= Time.deltaTime;
		}
		if (timer <= 0) 
		{
		Application.LoadLevel("EndMenu");	
		}
	}

	void OnGUI()
	{
		if (Application.loadedLevelName != "EndMenu") 
		{
			GUI.Box (new Rect (10, 10, 80, 20), "Time: " + timer.ToString ("0"));
		}

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Speed") 
			timer += 15;
	}
}
