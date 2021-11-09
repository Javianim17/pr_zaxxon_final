using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoInst : MonoBehaviour
{
    [SerializeField] GameObject prefabMapa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -570f)
        {
            instanciarMapa();
            
        }
    }

    void instanciarMapa()
    {
        Debug.Log("jjj");
        Destroy(gameObject) ;
        Instantiate(prefabMapa);
    }
}
