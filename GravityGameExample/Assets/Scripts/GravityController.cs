using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GravityController : MonoBehaviour 
{
	
	const float Gravity = 9.81f;
	

	public float gravityScale = 1.0f;
	
	void Update () 
	{
		Vector3 vector = new Vector3();


		vector.x = Input.GetAxis ("Horizontal");
		vector.z = Input.GetAxis ("Vertical");
		
	
		if (Input.GetKey ("z"))
		{
			vector.y = 1.0f;
		} else {
			vector.y = -1.0f;
		}
		
		if (Input.GetKey("r")){
			int scene = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(scene, LoadSceneMode.Single);
		}


		Physics.gravity = Gravity * vector.normalized * gravityScale;
	}
}