﻿using UnityEngine;
using System.Collections;

public class EnemyJump : MonoBehaviour {
	
	float moveTimer = 0f;
	bool moveRight = true;
	float jumpTimer = 0f;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Junky") 
			Destroy (gameObject);
	}
	void Update(){
		
		if(jumpTimer > 3f){
			rigidbody.AddForce(new Vector3(0f, 400f, 0f));
			jumpTimer = 0f;
		}
		
		if(moveRight){
			moveTimer += Time.deltaTime;
			rigidbody.velocity = new Vector2(5f, rigidbody.velocity.y);
		}
		else{
			moveTimer -= Time.deltaTime;
			rigidbody.velocity = new Vector2(-5f, rigidbody.velocity.y);
		}
		
		if(moveTimer > 0.5f)
			moveRight = false;
		else if(moveTimer < 0f)
			moveRight = true;
		
		jumpTimer += Time.deltaTime;
	}
}