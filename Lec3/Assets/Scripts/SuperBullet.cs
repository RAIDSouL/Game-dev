using UnityEngine;
using System.Collections;

public class SuperBullet : MonoBehaviour {

	void OnCollisionEnter(Collision other) {

		GetComponent<Rigidbody>().isKinematic = true;
		GetComponent<ParticleSystem>().Play();
	}


}
