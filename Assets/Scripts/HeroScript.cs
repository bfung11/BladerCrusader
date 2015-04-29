﻿using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

	public int hitPoints = 10;
	public int baseAttack = 1;
	public int baseDefense = 1;
	public int baseSpeed = 1;

	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update is called once per physics frame
	void FixedUpdate () {
		float move;
		move = Input.GetAxisRaw ("Horizontal");
		rb.velocity = new Vector2 (move * baseSpeed, rb.velocity.y);
	}
}