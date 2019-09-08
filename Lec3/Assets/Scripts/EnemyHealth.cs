using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	// Use this for initialization
	int health;
	int maxhealth;

	bool isdead;

	void Start () {

		maxhealth = 10;
		health = 5;
		isdead = false;

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log("Health : " + health);

	}
	
	public void GetDamage(int damage)
	{
		health -= damage;

		if(health <=3)
		{
			GetComponent<MeshRenderer>().material.color = Color.red;
		}

		if(health <= 0 && !isdead)
		{
			Die();
		}
	}

	void Die()
	{
		Destroy(gameObject);
	}
}
