using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToJuego : MonoBehaviour
{
    bool Inicio;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(buttonName:"Inicio"))
        {
            Debug.Log("hola");
           cargarPartida();
        }
        
    }

    public void cargarPartida()
    {
        SceneManager.LoadScene(1);

    }

    public void empezarNueva()
    {
        SceneManager.LoadScene(1);
    }

    public void volverMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void opciones()
    {
        SceneManager.LoadScene(3);
    }
}
