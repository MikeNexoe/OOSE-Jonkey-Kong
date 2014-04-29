using UnityEngine;
using System.Collections;

 // The one who shoots/spawner
public class EnemyCop : MonoBehaviour {

	
	public Transform Spawner;
	public float spawnTime = 5.0f;
	
	private int spawned = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time > spawned * spawnTime){
			spawned++;
			Instantiate (Spawner, transform.position + transform.forward, Quaternion.identity);
		}
	}
	// Update is called once per frame
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Junky") 
			Destroy (gameObject);
	}
}
	
