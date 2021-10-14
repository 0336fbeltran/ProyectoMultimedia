using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour
{

    private GameObject Bola;
    int puntos;
    GameObject texto;
    TextMesh i;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }
    void Awake()
    {
        Bola = GameObject.Find("Bola");
        texto = GameObject.Find("Cube");
        i = texto.GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.name == "Bola")
        {
            source = GetComponent<AudioSource>();
            puntos++;
            i.text = "Puntos: " + puntos;
            Debug.Log("Punto anotado");
            Destroy(Bola);
            source.Play(); // Reusar esta parte de codigo para cuando collisione y busquemos sonidos. 
            // Solo añadir el archivo al objeto y quitar el "Sound on awake" de sus propiedades
        }
    }
}
