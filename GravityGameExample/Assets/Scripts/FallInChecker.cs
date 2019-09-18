using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FallInChecker : MonoBehaviour 
{
	public Hole red;
	public Hole blue;
	public Hole green;
	public string Scene;

	void Update()
	{
		if (red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
		{
			SceneManager.LoadScene(Scene);
		}
	}
}