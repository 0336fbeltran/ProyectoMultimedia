using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorAleatorio : MonoBehaviour
{
	Color nuevo;
	float r, g, b;
	
    // Start is called before the first frame update
    void Start()
    {

      
    }

    // Update is called once per frame
    void Update()
    {

    }

     private void OnCollisionEnter(Collision collision)
    {
    	r = Random.Range(0f, 1f);
    	g = Random.Range(0f, 1f);
    	b = Random.Range(0f, 1f);
    	nuevo = new Color(r, g, b, 1);
        if (collision.collider.name =="Bola") 
        GetComponent<Renderer>().material.color = nuevo;
        
     
    }
}
