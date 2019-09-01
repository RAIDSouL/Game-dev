using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {

	public GameObject blueBox;
	public GameObject yellowBox;
	public GameObject blueBall;
	public GameObject yellowBall;
	
	Vector3 spawnPosition;
	
	GameObject box;
	GameObject ball;
	
	void Start () {
		
		StartCoroutine("RectangleSpawn",1.0f);
		StartCoroutine("CircleSpawn",1.0f);
	}


	IEnumerator RectangleSpawn(float delayTime){

		while(true){
			
			float offsetX = Random.Range(-2.0f,2.0f);
			float offsetZ = Random.Range(-2.0f,2.0f);

			spawnPosition.Set(transform.position.x+offsetX,transform.position.y,transform.position.z+offsetZ);

			box= Random.value < 0.5 ? blueBox : yellowBox;

			Instantiate(box,spawnPosition,Random.rotation);

			yield return new WaitForSeconds(delayTime);
		}
	}

	IEnumerator CircleSpawn(float delayTime){

		while(true){

			float theta = Random.Range(0.0f,2.0f*Mathf.PI);
			float r = Random.Range(4.0f,6.0f);

			spawnPosition.Set (transform.position.x+r*Mathf.Cos(theta),transform.position.y,transform.position.z+r*Mathf.Sin(theta));

			ball = Random.value < 0.1 ? blueBall : yellowBall;

			Instantiate(ball,spawnPosition,Quaternion.identity);

			yield return new WaitForSeconds(delayTime);
		}
	}
	
	void Update () {
		
	}
}



/*
 *
===

	public GameObject blueBall;
	public GameObject yellowBall;

	Vector3 spawnPosition;

	GameObject ball;

	void Start () {

		StartCoroutine("SpawnBall",0.1f);
	}

	IEnumerator SpawnBall(float delayTime){

		while(true){

			float theta = Random.Range(0.0f,2.0f*Mathf.PI);
			//float r = 30.0f;
			float r = Random.Range(10.0f,20.0f);

			spawnPosition.Set (transform.position.x+r*Mathf.Cos(theta),transform.position.y,transform.position.z+r*Mathf.Sin(theta));

			ball = Random.value < 0.1 ? blueBall : yellowBall;

			Instantiate(ball,spawnPosition,Quaternion.identity);

			yield return new WaitForSeconds(delayTime);
		}
	}

	void Update () {

	}
}
===
public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;

	Vector3 spawnPosition;


	GameObject ball;

	void Start () {

		StartCoroutine("SpawnBall",0.1f);


	}

	IEnumerator SpawnBall(float delayTime){

		while(true){
			float offsetX = Random.Range(-20.0f,20.0f);
			float offsetZ = Random.Range(-20.0f,20.0f);

			spawnPosition.Set(transform.position.x+offsetX,transform.position.y,transform.position.z+offsetZ);

			ball = Random.value < 0.1 ? blueBall : yellowBall;

			Instantiate(ball,spawnPosition,Quaternion.identity);

			yield return new WaitForSeconds(delayTime);
		}
	}

	void Update () {

	}
}

===
public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;

	Vector3 spawnPosition;
	bool nextIsBlue;

	GameObject ball;

	void Start () {

		StartCoroutine("SpawnBall",0.1f);
		nextIsBlue = true;

	}

	IEnumerator SpawnBall(float delayTime){

		while(true){
			float offsetX = Random.Range(-20.0f,20.0f);
			float offsetZ = Random.Range(-20.0f,20.0f);

			spawnPosition.Set(transform.position.x+offsetX,transform.position.y,transform.position.z+offsetZ);

			ball = nextIsBlue? blueBall : yellowBall;
			Instantiate(ball,spawnPosition,Quaternion.identity);

			nextIsBlue = !nextIsBlue;

			yield return new WaitForSeconds(delayTime);
		}
	}

	void Update () {

	}
}


===

public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;


	void Start () {

		StartCoroutine("SpawnBall",2.0f);

	}

	IEnumerator SpawnBall(float delayTime){

		while(true){
			float offsetX = Random.Range(-3.0f,3.0f);
			float offsetZ = Random.Range(-3.0f,3.0f);

			Vector3 spawnPosition = new Vector3(transform.position.x+offsetX,transform.position.y,transform.position.z+offsetZ);

			Instantiate(blueBall,spawnPosition,Quaternion.identity);
			Instantiate(yellowBall,spawnPosition,Quaternion.identity);
			yield return new WaitForSeconds(delayTime);
		}
	}

	void Update () {

	}
}
====
public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;


	void Start () {

		StartCoroutine("SpawnBall",2.0f);

	}

	IEnumerator SpawnBall(float delayTime){

		while(true){
			Instantiate(blueBall,transform.position,Quaternion.identity);
			Instantiate(yellowBall,transform.position,Quaternion.identity);
			yield return new WaitForSeconds(delayTime);
		}
	}

	void Update () {

	}
}


======
public class SpawnBall : MonoBehaviour {

	public GameObject yellowBall;


	float intervalTime;

	void Start () {

		intervalTime = 1.0f;

		StartCoroutine("SpawnBall");

	}

	IEnumerator SpawnBall(){

		while(true){
			Instantiate(blueBall,transform.position,Quaternion.identity);
			Instantiate(yellowBall,transform.position,Quaternion.identity);
			yield return new WaitForSeconds(intervalTime);
		}
	}

	void Update () {

	}
}

======
public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;

	float timer;
	float intervalTime;

	void Start () {

		intervalTime = 1.0f;
		timer = 0.0f;
	
	}
	
	void Update () {

		timer = timer + Time.deltaTime;

		if(timer >= intervalTime){

			Instantiate(blueBall,transform.position,Quaternion.identity);
			Instantiate(yellowBall,transform.position,Quaternion.identity);

			timer = 0.0f;
		}
	}
}
public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;

    void Start () {

	}
	
	void Update () {

	    Instantiate(blueBall,transform.position,Quaternion.identity);

	}
}
=

======

public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;

    void Start () {

	}
	
	void Update () {

	    Instantiate(blueBall,transform.position,Quaternion.identity);
		Instantiate(yellowBall,transform.position,Quaternion.identity);
	
	}
}
=========

public class SpawnBall : MonoBehaviour {

	public GameObject blueBall;
	public GameObject yellowBall;

	float timer;
	float intervalTime;

	void Start () {

		intervalTime = 1.0f;
		timer = intervalTime;
	
	}
	
	void Update () {

		timer = timer - Time.deltaTime;

		if(timer <= 0.0f){

			Instantiate(blueBall,transform.position,Quaternion.identity);
			Instantiate(yellowBall,transform.position,Quaternion.identity);

			timer = intervalTime;
		}
	}
}


*/