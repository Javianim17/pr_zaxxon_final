using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    float speed = 30f;
    
    float masVelocidad = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 20f;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        
        speed = speed + masVelocidad;
    }
}
