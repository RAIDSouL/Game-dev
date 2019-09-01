using UnityEngine;
using System.Collections;

public class Power : MonoBehaviour {

	public float speed;
	public int boostValue;
	public AudioClip pickUpClip;

	AudioSource audioSource;

	void Start () {
		
		audioSource = gameObject.AddComponent<AudioSource> ();

	}

	void Update () {
		
		transform.Rotate (speed*Time.deltaTime,0.0f,0.0f);

	}

	void OnTriggerEnter(Collider obj){

		if(obj.gameObject.CompareTag("Player")){
			
			obj.GetComponent<PlayerHealth>().AddHealth(boostValue);

			audioSource.clip = pickUpClip;
			audioSource.Play ();
			Destroy (gameObject,pickUpClip.length);


		}

	}

}
