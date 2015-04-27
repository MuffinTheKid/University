using UnityEngine;
using System.Collections;

public class SpawnPointController : MonoBehaviour {
	public int numSpawnPoints = 10;
	public GameObject[] spPoints;
	public GameObject spwnPoint;
	public float radius = 5.0f;
	// Use this for initialization
	void Start () {
		spPoints = new GameObject[numSpawnPoints];
		for(int i = 0; i < numSpawnPoints; i++)
		{
			Vector2 pos = Random.insideUnitCircle * radius;
			spPoints[i] = Instantiate(spwnPoint, new Vector3(pos.x, pos.y, 0.0f), Quaternion.identity) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public Vector3 getRandomPoint()
	{
		GameObject theOne = spPoints[Random.Range(0, numSpawnPoints - 1)];
		return theOne.transform.position;
	}
}
