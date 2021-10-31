using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Desaparecer : MonoBehaviour
{
    
    public Color redColor, blueColor;
    Color currentColor;
    MeshRenderer myRenderer;
    Color finalColor;
  

    void Start ()
    {
        myRenderer = GetComponent<MeshRenderer>();
        currentColor = myRenderer.material.color; // Color actual
       

    }
   void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
      
            if (currentColor == redColor)
            {
                currentColor = blueColor;
            }
            else
            {
                currentColor = redColor;
            }
           
                myRenderer.material.color = Color.Lerp(myRenderer.material.color, currentColor, Mathf.PingPong(Time.deltaTime+0.01f, 1));
           
            
            
        }
        
    }
}