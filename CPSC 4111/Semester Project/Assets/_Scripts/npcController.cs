using UnityEngine;
using System.Collections;
using System;

public class npcController : MonoBehaviour {
	public static event Action<GameObject> die;
	public Sprite[] sprites = new Sprite[9];
	public SpriteRenderer sRender;
	
	// Use this for initialization
	void Start () {
		sRender = gameObject.GetComponent<SpriteRenderer>();
		sRender.sprite = sprites[UnityEngine.Random.Range (0, 8)];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if(die != null)
		{
			die(gameObject);
			gameObject.SetActive (false);
		}
	}
	
}
