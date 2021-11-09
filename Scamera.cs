using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scamera : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 Pcamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 Dposition = target.position + Pcamera;
        Vector3 Sposition = Vector3.Lerp(transform.position, Dposition, speed * Time.deltaTime);

        transform.position = Sposition;
    }
}
