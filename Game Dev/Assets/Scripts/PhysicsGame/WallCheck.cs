using UnityEngine;
using System.Collections;

public class WallCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj){

		if(obj.gameObject.CompareTag("board")){
			obj.GetComponent<MoveBoard>().ChangeBoardDirection();

		}
	}
}
