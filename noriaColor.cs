using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noriaColor : MonoBehaviour
{
	GameObject suelo;
    Color color;
    MeshRenderer renderer;
   
    Color uno;
    Color dos;
    Color tres;
    Color cuatro;
    Color cinco;

    float tiempoTranscurrido;

    float tiempo2;
    int tiempo;

    // Start is called before the first frame update
    void Start()
    {
    	GameObject.Find("Suelo");
        
     
  		
  	
        //final = new Color(1, 0, 1, 1);
        uno = new Color(1, 0, 0, 1);
        dos = new Color(1, 1, 0, 0);
        tres = new Color(0,0,1,1);
        cuatro = new Color(0,1,1,0);
        cinco = new Color (0, 1, 0,1);
        GetComponent<Renderer>().material.color = uno;


        renderer = GetComponent<MeshRenderer>();
         color = renderer.material.color; 
         tiempoTranscurrido = 5f;
    }

    // Update is called once per frame
    void Update()
    {
tiempoTranscurrido += Time.deltaTime;

if (tiempoTranscurrido <5)
    	GetComponent<Renderer>().material.color = Color.Lerp(uno, dos, (tiempoTranscurrido+= Time.deltaTime) / 4);
    	


else if (tiempoTranscurrido>5 && tiempoTranscurrido<10 ) {
	tiempo2 = tiempoTranscurrido -5;
	  GetComponent<Renderer>().material.color = Color.Lerp(dos, tres, tiempo2 / 4);

}
else if (tiempoTranscurrido>10 && tiempoTranscurrido<15) {
	tiempo2 = tiempoTranscurrido -10;
	  GetComponent<Renderer>().material.color = Color.Lerp(tres, cuatro, tiempo2 / 4);
}

else if (tiempoTranscurrido>15 && tiempoTranscurrido<20) {
	tiempo2 = tiempoTranscurrido -15;
	  GetComponent<Renderer>().material.color = Color.Lerp(cuatro, cinco, tiempo2/ 4);
}

else if (tiempoTranscurrido>20 && tiempoTranscurrido<25) {
	tiempo2 = tiempoTranscurrido -20;
	  GetComponent<Renderer>().material.color = Color.Lerp(cinco, uno, tiempo2 / 4);
}
	else if (tiempoTranscurrido>25)
	tiempoTranscurrido = 0f;
}

      

    }

