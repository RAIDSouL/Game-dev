using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenlight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LightOut");
    }

    // Update is called once per frame
    IEnumerator LightOut()
    {
        while (true)
        {
            GetComponent<Light>().enabled = false;
            // Debug.Log("sad");
            yield return new WaitForSeconds(1);
            GetComponent<Light>().enabled = true;
            // Debug.Log("life");
            yield return new WaitForSeconds(1);
        }
    }

}
