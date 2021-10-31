using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CapturaPuntos : MonoBehaviour
{

    private GameObject Bola;
   static  int puntos;
    GameObject texto;
    TextMesh i;
             Scene currentScene;
           
    // AudioSource source;
    // Start is called before the first frame update
    void Start()
    {

        currentScene= SceneManager.GetActiveScene ();
  
           if (currentScene.name == "level1") 
        puntos = 0;
    }
    void Awake()
    {
        Bola = GameObject.Find("Bola");
        texto = GameObject.Find("Puntos");
        i = texto.GetComponent<TextMesh>();
 i.text = "Puntos: " + puntos;
    }
void update() {
    if (puntos > 600)
    puntos = 600;
}
    // Update is called once per frame
    void OnCollisionEnter(Collision objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.collider.name == "Seta")
        {

            puntos = puntos + 22;
            i.text = "Puntos: " + puntos;
            Debug.Log("Punto anotado");
            // TODO Añadir diferentes objetos que sumen diferentes puntos
        }
        else if (objetoQueHaEntrado.collider.name == "Rombo")
        {
            puntos = puntos + 15;
            i.text = "Puntos: " + puntos;
        }
        else if (puntos >= 600 && currentScene.name == "level1" )
        {
            puntos = 600;
            SceneManager.LoadScene(2);
        }
    }
}            