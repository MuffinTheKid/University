using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class characterMovement : MonoBehaviour {
	public static event Action<GameObject> hit;
	public float maxSpeed = 130;
	Animator anim;
	Vector2 movement;
	bool moving;
	bool facingRight = true;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		//Handles maintaining speed even when moving diagonally
		if(movement.magnitude > 1f)
		{
			movement = movement.normalized;
		}

		//Handles animation
		anim.SetFloat("moving", Mathf.Abs(movement.x));

		//moves gameobject
		rigidbody2D.velocity = new Vector2(movement.x * maxSpeed, movement.y * maxSpeed);

		//determines and sets the direction that the gameobject is facing
		if(movement.x > 0 && !facingRight)
		{
			Flip();
		}
		else if(movement.x < 0 && facingRight)
		{
			Flip();
		}
	}

	//flips the scale of the gameobject
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	/*void OnCollisionEnter2D(Collision2D collision)
	{
		if(hit)
		{
			hit(gameObject);
		}
	}*/

}