using UnityEngine;
using System.Collections;

public class npcSpawnController : MonoBehaviour {
	public GameObject[] npcSpawnPoints = new GameObject[6];
	public Transform[] positions = new Transform[6];
	public GameObject npcSpawnPoint;

	public float radius = 1.5f;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 5; i++)
		{
			//Vector2 pos = Random.insideUnitCircle * radius;
			int rand = UnityEngine.Random.Range(0, 5);
			Vector3 pos = positions[rand].position;
			npcSpawnPoints[i] = Instantiate(npcSpawnPoint, pos, Quaternion.identity) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 getRandomPoint()
	{
		GameObject theOne = npcSpawnPoints[Random.Range(0, npcSpawnPoints.Length - 1)];
		return theOne.transform.position;
	}
}
