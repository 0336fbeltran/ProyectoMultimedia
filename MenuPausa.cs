using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    Camera camara;
    Camera pausa;
    bool parado;
    // Start is called before the first frame update
    void Start()
    {
        camara = GameObject.Find("Main Camera").GetComponent<Camera>();
        pausa = GameObject.Find("Pausa").GetComponent<Camera>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) // Cuando se libere la tecla escape, se cambia de camara y se para el juego 
        {
            parado = true;
            camara.enabled = false;
            pausa.enabled = true;
            Time.timeScale = 0;

        }
        if (Input.GetKeyUp(KeyCode.Space) && parado == true) // Si el juego está parado y se libera la tecla espacio, se reanuda el juego y se vuelve a la camara original
        {
            pausa.enabled = false;
            camara.enabled = true;
            Time.timeScale = 1;
            parado = false;
        }


    }
}
