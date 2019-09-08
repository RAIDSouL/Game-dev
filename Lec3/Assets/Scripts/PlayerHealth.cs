using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	int initialHealth ;
	int maxHealth;
	int health;
	bool isDead;

	void Start () {
		
		initialHealth = 5;
		maxHealth = 20;

		health = initialHealth;
		isDead = false;
	
	}
	
	void Update () {
	
		Debug.Log("P_Health: " + health);
	
	}

	public void GetDamage(int damage){

		health -= damage;
	
		if(health <= 2)
			GetComponent<MeshRenderer>().material.color = Color.red;
		
		if(health <= 0 && !isDead){
		
			Die();
			// Reload the current scene
			int scene = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(scene, LoadSceneMode.Single);
		
		}

	}

	public void AddHealth(int boost){

		health += boost;
	
		if(health >= maxHealth){
			SceneManager.LoadScene ("Scene2");
		}else if(health >= 15){
			GetComponent<MeshRenderer>().material.color = Color.white;
		}else{
			GetComponent<MeshRenderer>().material.color = Color.blue;
		}
		
	}

	void Die(){

		Destroy(gameObject);

	}
}
