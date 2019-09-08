using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public int TrapDamage;
    public AudioClip pickUpClip;
	public AudioSource audioSource;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider obj){

		if(obj.gameObject.CompareTag("Player")){
			
			obj.GetComponent<PlayerHealth>().GetDamage(TrapDamage);

			audioSource.clip = pickUpClip;
			audioSource.Play ();
			Destroy (gameObject,pickUpClip.length);


		}
    }
}
