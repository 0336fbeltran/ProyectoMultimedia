using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarNuevaBola : MonoBehaviour
{

    Vector3 posicion; 
    private GameObject Bola;
    mantenerZ mantener;
    int vidas;
    
    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        Bola = GameObject.Find("Bola");
        posicion = Bola.transform.position;
    }
    void Destroy()
    {
        Destroy(Bola);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider coll)
    { 
        if (coll.name =="Bola" && vidas >1)
        {vidas--;
           
           // Destroy();
           // Bola = GameObject.Instantiate(Bola); // Instancia bola
//Bola.name = "Bola"; // Cambia el nombre a Bola 
                       
            Bola.transform.position = posicion; // La coloca en el punto de inicio (Colocar coordenadas de tirador de pinball)
        }
    }

    }
