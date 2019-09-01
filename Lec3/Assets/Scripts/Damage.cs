using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	public float speed;
	public int damageValue;
	public AudioClip damageClip;

	AudioSource audioSource;

	void Start () {
		
		audioSource = gameObject.AddComponent<AudioSource> ();

	}
	
	void Update () {

		transform.Rotate (speed*Time.deltaTime,0.0f,0.0f);
	
	}

	void OnTriggerEnter(Collider obj){

		if(obj.gameObject.CompareTag("Player")){
			
			obj.GetComponent<PlayerHealth>().GetDamage(damageValue);

			audioSource.clip = damageClip;
			audioSource.Play ();

			Destroy (gameObject,damageClip.length);

		}

	}
}
