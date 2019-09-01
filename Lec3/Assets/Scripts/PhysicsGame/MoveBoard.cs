using UnityEngine;
using System.Collections;

public class MoveBoard : MonoBehaviour {

	public float speed;


	void Start () {
		//speed = 100.0f;
	}
	

	void Update () {

		transform.Translate(speed*Time.deltaTime,0.0f,0.0f);

	}

	public void ChangeBoardDirection(){

		speed = -speed;
	}
}










//transform.Translate(speed*Time.deltaTime,0.0f,0.0f);
//transform.Rotate(0.0f,speed*Time.deltaTime,0.0f);

//transform.Rotate (new Vector3(0.0f,1.0f,0.0f),speed*Time.deltaTime);
//transform.Rotate (Vector3.up,speed*Time.deltaTime);
//transform.Rotate (Vector3.forward,speed*Time.deltaTime);
//transform.Rotate (-Vector3.forward,speed*Time.deltaTime);
//transform.Rotate (Vector3.right,speed*Time.deltaTime);

