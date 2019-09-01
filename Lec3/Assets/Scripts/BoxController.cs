using UnityEngine;
using System.Collections;

public class BoxController : MonoBehaviour {

	//public GameObject boxExplosion;
	public AudioClip hitClip;
	AudioSource audioSource;


	void Start () {
		
		audioSource = gameObject.AddComponent<AudioSource> ();

	}
	

	void Update () {
	}

	void OnCollisionEnter(Collision obj){
		if(obj.gameObject.CompareTag("bullet")){

			audioSource.clip = hitClip;
			audioSource.Play ();
			//Instantiate (boxExplosion, transform.position, Quaternion.identity);


			Destroy (gameObject, hitClip.length);

		}



	}
}
