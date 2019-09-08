using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public static Boom PointBoom;
    public AudioClip KaBoom;
	public AudioSource PlayBoomSound;

    public void PlaySound()
    {
        PlayBoomSound.clip = KaBoom;
        PlayBoomSound.Play ();
    }

    void Awake()
    {
        PointBoom = this;
    }
    
}
