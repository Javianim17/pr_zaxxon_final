using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agh : MonoBehaviour
{
    public float speedH;
    public float speedV;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float desplaH = speedH * Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * desplaH);

        float desplaV = speedV * Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * desplaV);
        
        float rot = Input.GetAxis("Horizontal-J2"); //He creado un eje nuevo para la rotación
        //print(rot);
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 300f , Space.Self);
    }
}
