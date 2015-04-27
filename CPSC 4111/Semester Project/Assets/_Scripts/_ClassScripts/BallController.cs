using UnityEngine;
using System.Collections;
using System;

public class BallController : MonoBehaviour {
	public static event Action<GameObject> goingHome;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if(goingHome != null)
		{
			goingHome(gameObject);
			gameObject.SetActive (false);
		}

	}
}
