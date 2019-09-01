using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject spawnPoint;
	public GameObject enemy;

	void Start () {
		Spawn();
	}
	
	void Update () {
	
	}

	void Spawn(){

		Instantiate(enemy,spawnPoint.transform.position,spawnPoint.transform.rotation);
	}
}
