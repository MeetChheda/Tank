using UnityEngine;
using System.Collections;
public class SpawnItems : MonoBehaviour {
	public Transform[] SpawnPoints;
	public float spawnTime= 15.0f;
	 
	//public GameObject Power;
	public GameObject[] Power;



	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnPower", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnPower()
	{
		int spawnIndex = Random.Range (0, SpawnPoints.Length);
		int objectIndex = Random.Range (0, Power.Length);


		Instantiate (Power[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);

	}
}
