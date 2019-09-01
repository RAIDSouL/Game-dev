using UnityEngine;
using System.Collections;

public class BigGun : MonoBehaviour {

	public GameObject bullet;
	public float initialSpeed;
	public float intervalTime;

	Vector3 bulletDirection;

	void Start () {	

		InvokeRepeating("Shooting",3.0f,intervalTime);

	}
		
	void  Shooting(){
		
		GameObject gunBullet = (GameObject)Instantiate(bullet,transform.position,transform.rotation);

		//bulletDirection = new Vector3 (0, 1.0f, 1.0f);

		bulletDirection = transform.up;

		gunBullet.GetComponent<Rigidbody>().velocity = bulletDirection.normalized*initialSpeed;



	}
}
