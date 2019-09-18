using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    Vector3 spawnPosition;
    void Start()
    {
        StartCoroutine("Spawnblock");
    }

    // Update is called once per frame
    IEnumerator Spawnblock()
    {
        while (true)
        {
            
            spawnPosition.Set(transform.position.x+Random.Range(-10,10),transform.position.y,transform.position.z+Random.Range(-10,10));
            Instantiate(cube,spawnPosition,Quaternion.identity);
            // Debug.Log(Random.Range(1,10));
            yield return new WaitForSeconds(0.2f);
        }
        
    }

}
