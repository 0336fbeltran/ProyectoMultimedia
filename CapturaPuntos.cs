using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaPuntos : MonoBehaviour
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
        texto = GameObject.Find("Puntos");
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
         
            // Creo una copia del objeto Bola, le pongo el nombre de Bola y la instancio en el mismo lugar que la original
            
      //      Bola = GameObject.Instantiate(Bola);
          //  Bola.name = "Bola";
            
        //   Bola.transform.position = new Vector3(9.12f, 4.77f, 13.93f);
            //
        }
    }
}