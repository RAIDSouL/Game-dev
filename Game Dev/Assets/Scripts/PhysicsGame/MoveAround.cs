using UnityEngine;
using System.Collections;

public class MoveAround : MonoBehaviour {


	public GameObject axisPoint;
	public float speed;

	void Start () {
		//speed = 100.0f;
	}
	

	void Update () {

		//transform.RotateAround(new Vector3(-10.0f,4.0f,7.0f),new Vector3(0.0f,1.0f,0.0f),speed*Time.deltaTime);
		transform.RotateAround(axisPoint.transform.position,axisPoint.transform.up,speed*Time.deltaTime);
	
	}


}
