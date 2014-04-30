using UnityEngine;
using System.Collections;

public class Junky : MonoBehaviour {

	public float jump;
	public float speed;
	public float distToGround;
	public float score;
	public bool right;
	public bool debuff;

	void Start () 
	{
		distToGround = collider.bounds.extents.y;
		jump = 400.0f;
		speed = 0.15f;
		right = true;
		debuff = false;

		if (Application.loadedLevelName == "Scene01") 
		{
			score = 0.0f;
		}
		if (Application.loadedLevelName == "Scene02") 
		{
			score = PlayerPrefs.GetFloat("Save");
		}
		if (Application.loadedLevelName == "EndMenu") 
		{
			score = PlayerPrefs.GetFloat("Save");
		}
	}

	//static bool Raycast(Vector3 )
	// Update is called once per frame
	void Update () 
	{
		Vector3 dwn = transform.TransformDirection (Vector3.down);
		if (Physics.Raycast (transform.position, dwn, 1.1f)) 
		{
			if (Input.GetKeyDown (KeyCode.Space))
				transform.rigidbody.AddForce (transform.up * jump);
			if (Input.GetKeyDown (KeyCode.LeftControl))
				transform.localScale -= new Vector3 (0, 0.25f, 0);
			if (Input.GetKeyUp (KeyCode.LeftControl)) 
			{
				transform.localScale += new Vector3 (0, 0.25f, 0);
				transform.position += new Vector3 (0, 0.1f, 0);
			}
		}	
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.position -= new Vector3 (speed, 0, 0);
			if (debuff == false)
			{
				if (right == true) 
				{
					//transform.localScale.x = -1;
					transform.localScale = new Vector3 (-1f, 1.8f, 1f);
					right = false;
				}
			}
			else
			{
				if (right == false)
				{
					//transform.localScale.x = -1;
					transform.localScale = new Vector3 (1f, 1.8f, 1f);
					right = true;
				}

			}
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.position += new Vector3 (speed, 0, 0);
			if (debuff == false)
			{
				if (right == false)
				{
					//transform.localScale.x = -1;
					transform.localScale = new Vector3 (1f, 1.8f, 1f);
					right = true;
				}
			}
			else 
			{
				if (right == true)
				{
					//transform.localScale.x = -1;
					transform.localScale = new Vector3 (-1f, 1.8f, 1f);
					right = false;
				}
			}
		}
		if (Input.GetKey (KeyCode.Escape)) 
			Application.Quit ();
		if (Application.loadedLevelName != "EndMenu") 
		{
			score -= Time.deltaTime;
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Buff") 
		{
			jump = 500.0f;
			speed = 0.15f;
			debuff = false;
		}
		if (other.gameObject.name == "Debuff") 
		{
			jump = 400.0f;
			speed = -0.15f;
			debuff = true;
		}
		if (other.gameObject.name == "Pill") 
			score += 10;
		if (other.gameObject.name == "LevelChange") 
			PlayerPrefs.SetFloat("Save", score);
		if (other.gameObject.name == "LevelChange2") 
			PlayerPrefs.SetFloat("Save", score);
	}

	void OnGUI()
	{
		GUI.Box (new Rect (180, 10, 100, 20), "Score: " + score.ToString ("0"));
	}
}