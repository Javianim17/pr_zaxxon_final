using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float desplSpeed;

    //Variables para la restricci�n de movimiento (horizontales y verticales)
    float limiteR = 50;
    float limiteL = -50;
    float limiteU = 50;
    float limiteS = 50;

    //Variable booleana que determina si puedo moverme o no
    bool inLimitH = true;
    bool inLimitV = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 2.3f, 0f);
        //Le asigno un valor a la velocidad de desplazamiento
        desplSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();



        float rot = Input.GetAxis("Horizontal-J2"); //He creado un eje nuevo para la rotaci�n
        //print(rot);
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 100f);

    }

    void MoverNave()
    {
        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");


        //Variables de posici�n en X y en Y para la restricci�n
        float posX = transform.position.x;
        float posY = transform.position.y;

        //Restrinjo el movimiento, de momento solo hacia la derecha
        if (posX > limiteR && desplH > 0 || posX < limiteL && desplH < 0)
        {
            inLimitH = false;
        }
        else
        {
            inLimitH = true;
        }

        if (posY > limiteU && desplV > 0 || posY < limiteS && desplV < 0)
        {
            inLimitV = false;
        }
        else
        {
            inLimitV = true;
        }

        if (inLimitH)
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplH * desplSpeed, Space.World);
        }


        if (inLimitV)
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplV * desplSpeed, Space.World);
        }

    }
}
