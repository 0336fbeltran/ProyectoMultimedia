using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarNuevaBola : MonoBehaviour
{

    Vector3 posicion; 
    private GameObject Bola;
    mantenerZ mantener;
    // Start is called before the first frame update
    void Start()
    {
        Bola = GameObject.Find("Bola");
        posicion = Bola.transform.position;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider coll)
    { 
        if (coll.name =="Bola")
        {
            Bola = GameObject.Instantiate(Bola); // Instancia bola
            Bola.name = "Bola"; // Cambia el nombre a Bola 
            mantener = Bola.GetComponent<mantenerZ>();
            mantener.enabled = true;
              
            Bola.transform.position = posicion; // La coloca en el punto de inicio (Colocar coordenadas de tirador de pinball)
        }
    }

    }
