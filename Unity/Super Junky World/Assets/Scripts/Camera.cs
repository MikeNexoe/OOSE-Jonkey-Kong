using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	
	GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(!player){
			Debug.LogWarning("Couldn't find a player, trying again!");
			player = GameObject.FindWithTag("Player");
		}
		else
			transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
	}
}