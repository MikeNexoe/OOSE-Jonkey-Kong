﻿using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	GameObject player;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Junky");
	}
	
	// Update is called once per frame
	void Update () {
		if(!player){
			Debug.LogWarning("Couldn't find a player, trying again!");
			player = GameObject.FindWithTag("Junky");
		}
		else
			transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
	}
}