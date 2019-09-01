using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string sceneName;

	void OnTriggerEnter(Collider obj){

		if (obj.gameObject.CompareTag ("Player")) {

			SceneManager.LoadScene (sceneName);
		}

	}
}
