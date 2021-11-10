using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] GameObject nave;
    float masVelocidad = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        
        
            speed = speed + masVelocidad;

        if (transform.position.x < -1200)
        {
            Destroy(gameObject);
        }

        
        
    }
    


}
