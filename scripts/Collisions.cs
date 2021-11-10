using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    [SerializeField] ParticleSystem explosion;
    public Run Run;

    float fuerzaTurbo = 100f;
    int vidas = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "colision")
        {
            vidas--;
            
            Instantiate(explosion);
            Debug.Log("explosion");
            if (vidas == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(2);

            }

        }


        if (other.tag == "boost")
        {
            Debug.Log("si");

            for (int i = 0; i < 5; i++)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * fuerzaTurbo);

            }
        }

       

    }

    
}
