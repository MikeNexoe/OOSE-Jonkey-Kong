using UnityEngine;
using System.Collections;

public class Junky : MonoBehaviour {

	public float jump;
	public float speed;
	public float distToGround;
	public float score = 0;

	void Start () 
	{
		distToGround = collider.bounds.extents.y;
		jump = 400.0f;
		speed = 0.15f;
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
			transform.position -= new Vector3 (speed, 0, 0);
		if (Input.GetKey (KeyCode.D))
			transform.position += new Vector3 (speed, 0, 0);
		score -= Time.deltaTime;
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Buff") 
		{
			jump = 500.0f;
			speed = 0.15f;
		}
		if (other.gameObject.name == "Debuff") 
		{
			jump = 400.0f;
			speed = -0.15f;
		}
		if (other.gameObject.name == "Pill") 
			score += 10;
	}
	void OnGUI()
	{
		GUI.Box (new Rect (180,10,100,20), "Score: " + score.ToString("0"));
	}
}