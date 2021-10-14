using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gatillo : MonoBehaviour
{
    GameObject gatillo;
    Vector3 maximo;
    Vector3 actual;
    float x, y, z;
    float tiempo, duracion, vuelta;
    Vector3 prueba;
    bool mantener;
  
    // Start is called before the first frame update
    void Start()
    {
        gatillo = GameObject.Find("Tirador");
        actual = gatillo.transform.position;
        x = gatillo.transform.position.x;
        y = gatillo.transform.position.y;
        z = gatillo.transform.position.z;
        tiempo = 0;
        duracion = 1f;
        vuelta = 0;
        maximo = new Vector3(x, (y - 2), z);
        mantener = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gatillo.transform.position = Vector3.MoveTowards(actual, maximo, tiempo / duracion);
            tiempo += Time.deltaTime;
            mantener = true;      
            
        }
        if (Input.GetKeyUp(KeyCode.DownArrow)) { 
        Debug.Log("ASAA");
            tiempo = 0;
            while (mantener)
            {
                gatillo.transform.position = Vector3.MoveTowards(maximo, actual, vuelta / duracion);
                vuelta += Time.deltaTime;
                if (gatillo.transform.position == actual)
                    mantener = false;
            }
        }
    }

}
