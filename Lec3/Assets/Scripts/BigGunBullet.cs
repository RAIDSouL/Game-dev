using UnityEngine;
using System.Collections;

public class BigGunBullet : MonoBehaviour {
	
	float startTime;
	float lifeTime;
	float timer;

	void Start(){
		
		lifeTime = 4.0f;
		startTime = Time.time;

	}

	void Update () {

		if(Time.time >= (startTime+lifeTime)){

			Destroy(gameObject);
		}
	}	
}
