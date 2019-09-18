using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    private float delayTime = 2.0f;
    void Start()
    {
        StartCoroutine("DeActive");
    }

    // Update is called once per frame
    IEnumerator DeActive(){
        while (true)
        {
            float rand_num = Random.value;
            if(rand_num > 0.9)
            {
                Destroy(gameObject);
            }
            yield return new WaitForSeconds(delayTime);
        }
    }
}
