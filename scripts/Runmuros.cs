using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runmuros : MonoBehaviour
{
    float speedM = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedM = 20f;
        transform.Translate(Vector3.back * speedM * Time.deltaTime);
    }
}
