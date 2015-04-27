using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class npcMovementController : MonoBehaviour {
	public bool facingRight = false;
	private List<Vector2> path;
	public GameObject targetPos;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
 	}
	
	// Update is called once per frame
	void Update () {
		targetPos = GameObject.Find("player_controller");
		path = NavMesh2D.GetSmoothedPath(transform.position, targetPos.transform.position);


		if(path!=null && path.Count != 0)
		{
			//Debug.Log("I am moving.");
			if(targetPos.transform.position.x > transform.position.x && !facingRight)
			{
				Flip();
				//rigidbody2D.AddForce(new Vector2(path[0].x * 0.5f, path[0].y * 0.5f));
				transform.position = new Vector2(transform.position.x - path[0].x, transform.position.y - path[0].y);
				anim.SetBool("moving", true);
			}
			else if(targetPos.transform.position.x < transform.position.x && facingRight)
			{
				Flip();
				//rigidbody2D.velocity = new Vector2(path[0].x * 0.25f, path[0].y * 0.5f);
				transform.position = new Vector2(transform.position.x - path[0].x, transform.position.y - path[0].y);
				//rigidbody2D.AddRelativeForce(new Vector2(path[0].x * 0.5f, path[0].y * 0.5f));
				anim.SetBool("moving", true);
			}

			if(Vector2.Distance(transform.position, path[0]) < 0.01f)
			{
				path.RemoveAt(0);
			}

		}
		else
		{
			anim.SetBool("moving", false);
			rigidbody2D.velocity = new Vector2(0, 0);
		}

	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
