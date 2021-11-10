using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateMapa : MonoBehaviour
{
    [SerializeField] GameObject Mapa;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        
        if (other.tag == "redo")
        {
            Debug.Log("damn");
            Vector3 posicion = new Vector3(147, 37, 3);
            
           
            Instantiate(Mapa, posicion, Quaternion.identity);

            
            
        }
    }
}
