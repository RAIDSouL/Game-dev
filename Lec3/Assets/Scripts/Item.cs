using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
 
    public AudioClip pickUpClip;
	public AudioSource audioSource;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider obj){

		if(obj.gameObject.CompareTag("Player"))
        {
			
			audioSource.clip = pickUpClip;
			audioSource.Play ();
			Destroy (gameObject,pickUpClip.length);
		}
    }
}
