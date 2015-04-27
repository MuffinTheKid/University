using UnityEngine;
using System.Collections;
using System;

public class npcObjectController : MonoBehaviour {
	public GameObject[] anObject = new GameObject[3];
	public npcSpawnController spController;
	public Queue queue;
	public int numObjects = 10;
	public float interval = 3.0f;
	public bool doIt = false;
	// Use this for initialization
	void Start () {
		queue = new Queue();
		doIt = true;
		for(int i = 0; i < numObjects; i++)
		{
			int rand = UnityEngine.Random.Range(0, 2);
			GameObject one = Instantiate(anObject[rand], Vector3.zero, Quaternion.identity) as GameObject;
			one.SetActive(false);
			queue.Enqueue(one);
		}
		StartCoroutine("spawn");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable()
	{
		npcController.die += dieing;
	}
	
	void OnDisable()
	{
		npcController.die -= dieing;
	}
	
	void dieing(GameObject what)
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
