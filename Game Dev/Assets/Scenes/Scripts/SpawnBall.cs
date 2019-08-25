using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour {
 
 	public GameObject blueBall;
 	public GameObject greenBall;
	public GameObject redBall;
    public GameObject L_blueBall;
 	public GameObject L_greenBall;
	public GameObject L_redBall;
	
 	Vector3 spawnPosition;
 
 	GameObject ball;
 
 	void Start () {
		
 	 	StartCoroutine("GenBall",0.05f);
        StartCoroutine("GenBallwall",0.01f);
		  
 	}
 
 	IEnumerator GenBall(float delayTime){
 	float theta = 0.0f;
	float deep = 0.0f;
       	while(true){
 
            	// อาณาเขตที่จะสร้างบอล กำหนดให้อยู่ในขอบเขตรูปวงกลมที่มีรัศมี
				// เท่ากับ r จากจุด SpawnPoint
            	// นอกจากนั้น ความยาวของรัศมีก็เป็นค่า random
 
            	
            	//float r = 30.0f;
            	float r = 40.0f;
				theta += 0.50f;
				deep += 0.05f;
                float rand_num = Random.value;
				
            	spawnPosition.Set ((Random.Range(-1,1)*10)+transform.position.x+r*Mathf.Cos(theta),(Random.Range(-1,1)*10)+transform.position.y+r*Mathf.Sin(theta),transform.position.z+deep);
                // spawnPosition.Set (transform.position.x+r*Mathf.Cos(theta),transform.position.y+r*Mathf.Sin(theta),transform.position.z+deep);
            	// ball = Random.value < 0.5 ? blueBall : greenBall;
                
                if (rand_num < 0.33f){
                    ball = L_blueBall;
                }
                else if(0.33f <= rand_num && rand_num < 0.66f){
                    ball = L_greenBall;
                }
                else{
                    ball = L_redBall;
                }

            	Instantiate(ball,spawnPosition,Quaternion.identity);
 
            	yield return new WaitForSeconds(delayTime);
       	} 
 	}
 
    IEnumerator GenBallwall(float delayTime){
 	float theta = 0.0f;
	float deep = 0.0f;
       	while(true){
 
            	// อาณาเขตที่จะสร้างบอล กำหนดให้อยู่ในขอบเขตรูปวงกลมที่มีรัศมี
				// เท่ากับ r จากจุด SpawnPoint
            	// นอกจากนั้น ความยาวของรัศมีก็เป็นค่า random
 
            	
            	//float r = 30.0f;
            	float r = 50.0f;
				theta += 0.50f;
				deep += 0.05f;
                float rand_num = Random.value;
				
            	spawnPosition.Set (transform.position.x+r*Mathf.Cos(theta),transform.position.y+r*Mathf.Sin(theta),transform.position.z+deep);
 
            	// ball = Random.value < 0.5 ? blueBall : greenBall;
                
                if (rand_num < 0.33f){
                    ball = blueBall;
                }
                else if(0.33f <= rand_num && rand_num < 0.66f){
                    ball = greenBall;
                }
                else{
                    ball = redBall;
                }

            	Instantiate(ball,spawnPosition,Quaternion.identity);
 
            	yield return new WaitForSeconds(delayTime);
       	} 
 	}
}