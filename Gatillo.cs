using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gatillo : MonoBehaviour
{
    private GameObject gatillo;
    Collider bola;
    private Vector3 maximo;
    private Vector3 actual; // La posicion actual es algo menor a la que golpea la bola
    private float x, y, z;
    private float tiempo, duracion, vuelta;
    private Vector3 prueba;
    private bool mantener;
    private Rigidbody rigidBody_ball;
    float fuerza;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
            audio = GetComponent<AudioSource>();
        bola = GameObject.Find("Bola").GetComponent<SphereCollider>();
        fuerza = 0;
        gatillo = GameObject.Find("Tirador");
        actual = gatillo.transform.position;
        x = gatillo.transform.position.x;
        y = gatillo.transform.position.y;
        z = gatillo.transform.position.z;
        tiempo = 0;
        duracion = 1f;
        vuelta = 0;
        maximo = new Vector3(x, y, (-6.477f));
        prueba = new Vector3(x, y, (-4.941f)); // Posicion en la que golpea a la bola
        mantener = false;
        rigidBody_ball = GameObject.Find("Bola").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.JoystickButton0))
        {
            gatillo.transform.position = Vector3.MoveTowards(actual, maximo, tiempo / duracion);
            tiempo += Time.deltaTime;
            mantener = true;
            //while (actual!=maximo) poner que deje de sumar fuerza al llegar al final 

            if (fuerza < 15)
            {
                fuerza = tiempo * 10;
            }
            else if (fuerza >= 14) //Arregla bugs de Unity 
                fuerza = 30;
            Debug.Log(fuerza);
            //TODO REINICIAR LA FUERZA CUANDO NO GOLPEA UNA BOLA


        }
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.JoystickButton0))
        {
            audio.Play();
            Debug.Log("Tirando bola...");
            tiempo = 0;

            while (mantener)
            {
                gatillo.transform.position = Vector3.MoveTowards(maximo, prueba, vuelta / 5);
                vuelta += Time.deltaTime;
                if (gatillo.transform.position == prueba)
                {
                    mantener = false;

                }


            }


        }
    }
    void OnCollisionEnter(Collision objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.collider.name == "Bola")
        {
            rigidBody_ball.AddForce(0f, 0f, fuerza, ForceMode.Impulse);
            fuerza = 0;
        }
    }
}