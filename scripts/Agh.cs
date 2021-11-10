using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agh : MonoBehaviour
{
    public float speedH;
    public float speedV;

    [SerializeField] float fuerzaTurbo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float desplaH = speedH * Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * Time.deltaTime * desplaH, Space.World);

        float desplaV = speedV * Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * desplaV, Space.World);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * fuerzaTurbo);
        }

        float rot = Input.GetAxis("Horizontal-J2"); //He creado un eje nuevo para la rotación
        //print(rot);
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 300f , Space.Self);


        //if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * speedH * Time.deltaTime);
            //transform.Translate(Vector3.up * 7 * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, 90, -25);

            
        }
        //if (Input.GetKeyUp(KeyCode.D))
        {
            //transform.eulerAngles = new Vector3(0, 90, 00);
        }

        //if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * speedH * Time.deltaTime);
            //transform.Translate(Vector3.up * 7 * Time.deltaTime);
            //transform.eulerAngles = new Vector3(0, 90, 25);


        }
        //if (Input.GetKeyUp(KeyCode.A))
        {
            //transform.eulerAngles = new Vector3(0, 90, 00);
        }

        //if (Input.GetKeyDown(KeyCode.AltGr))
        {
            //transform.eulerAngles= new Vector3(0, 90, 25);
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.eulerAngles = new Vector3(0, 90, 0);
        }
        //if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            //transform.eulerAngles = new Vector3(0, 90, -25);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
