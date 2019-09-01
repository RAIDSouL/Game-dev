using UnityEngine;
using System.Collections;

public class MySpawnBall : MonoBehaviour {

	// Use this for initialization

	public GameObject redBall;
	public GameObject yellowBall;

	void Start () {



	
	}
	

	void Update () {

		Instantiate (redBall, transform.position, Quaternion.identity);
		Instantiate (yellowBall, transform.position, Quaternion.identity);
	
	}
}
