using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mantenerZ : MonoBehaviour
{
    GameObject[] Bola;
    Vector3 actual;
    float x, y, z;
    int a;


    // Update is called once per frame
    void Update()
    {

        Bola = GameObject.FindGameObjectsWithTag("Bola"); // Busco todos los objetos con tag "Bola"
      
        foreach (GameObject Bola in Bola) {

            actual = Bola.transform.position;
            x = Bola.transform.position.x;
            y = Bola.transform.position.y;
            z = 14.253f; // mantengo el valor de Z para que la bola no caiga "Hacia la camara", solo nos interesa que cambie X o Y 
            Bola.transform.position = new Vector3(x, y, z);
        }

    }

}