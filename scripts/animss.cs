using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animss : MonoBehaviour
{
    [SerializeField] bool zonaA = false;
    [SerializeField] AnimationClip A;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AnimationClip>();
    }

    // Update is called once per frame
    void Update()
    {
       
        

        
    }

    private void OnTriggerEnter(Collider other)
    {
        bool zonaA = true;
        
        
    }
}
