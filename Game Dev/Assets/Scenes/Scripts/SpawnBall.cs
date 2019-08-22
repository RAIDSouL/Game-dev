using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject myredball;
    public GameObject myblueball;
    float intervalTime;
    void Start()
    {
        intervalTime = 1.0f;
 
       	InvokeRepeating("GenerateBall",5.0f,0.2f);
    }

    IEnumerator GenerateBall(){
 
       	while(true){
            	Instantiate(myblueball,transform.position,Quaternion.identity);
       	 	    Instantiate(myredball,transform.position,Quaternion.identity);
       	}
 	}

}
