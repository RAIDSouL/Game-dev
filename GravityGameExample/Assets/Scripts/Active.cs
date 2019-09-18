using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    public float delayTime;
    void Start()
    {
        StartCoroutine("Active");
    }

    // Update is called once per frame
    IEnumerator DeActive(){
        while (true)
        {
            float rand_num = Random.value;
            // if(rand_num > 0.9)
            // {
                cube.SetActive(true);
            // }
            yield return new WaitForSeconds(delayTime);
        }
    }
}
