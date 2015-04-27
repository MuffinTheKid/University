using UnityEngine;
using System.Collections;
using System;


public class ObjectController : MonoBehaviour {
	public GameObject anObject;
	public SpawnPointController spController;
	public Queue queue;
	public int numObjects = 10;
	public float interval = 3.0f;
	public bool doIt = false;

	// Use this for initialization
	void Start () 
	{
		queue = new Queue();
		for(int i = 0; i < numObjects; i++)
		{
			GameObject one = Instantiate(anObject, Vector3.zero, Quaternion.identity) as GameObject;
			one.SetActive(false);
			queue.Enqueue(one);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(10, 10, 100, 50), (doIt?"Stop":"Start")))
		   {
				doIt = !doIt;
				StartCoroutine("spawn");
		   }
	}

	void OnEnable()
	{
		BallController.goingHome += comingHome;
	}

	void OnDisable()
	{
		BallController.goingHome -= comingHome;
	}

	void comingHome(GameObject what)
	{
		queue.Enqueue(what);
	}

	IEnumerator spawn()
	{
		while(doIt)
		{
			if(queue.Count > 0)
			{
				GameObject another = queue.Dequeue() as GameObject;
				another.transform.position = spController.getRandomPoint();
				another.SetActive(true);
			}

			yield return new WaitForSeconds(interval);
		}
	}
		
}
