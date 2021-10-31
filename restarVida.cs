using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class restarVida : MonoBehaviour
{

	    GameObject texto;
	  public Image whiteFade;
    TextMesh i;
   static int vidas;
    float time;
AudioSource audio;
int contador;
  Scene currentScene;
            
    // Start is called before the first frame update
    void Start()
    {
                currentScene= SceneManager.GetActiveScene ();
       
    	contador = 0;
    	whiteFade = GameObject.Find("GameOver").GetComponent<Image>();
    	whiteFade.canvasRenderer.SetAlpha(0);
    	audio = GetComponent<AudioSource>();
    	
    	time = 0;
                texto = GameObject.Find("Vidas");
        i = texto.GetComponent<TextMesh>();
         if (currentScene.name == "level1") {
        vidas = 3;
        
        i.text = "Vidas: " + vidas;
        }
    }

    // Update is called once per frame
    void Update()
    {
             i.text = "Vidas: " + vidas;
    	if (vidas == 0) {
    		if (contador == 0)
    		audio.Play();
    		contador++;
    		whiteFade.canvasRenderer.SetAlpha(Mathf.Lerp(0, 1, time/ 1));
            time += Time.deltaTime;
            if (time>5)
    		SceneManager.LoadScene(0);
    	}
        
    }

     void OnTriggerEnter(Collider objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.GetComponent<Collider>().name == "Bola") {

        vidas--;

    }
        i.text = "Vidas: " + vidas;
    }
}
