using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
	static float tiempo;
	int segundos;
      Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
                  currentScene= SceneManager.GetActiveScene ();
    
   if (currentScene.name == "level1") 
    	tiempo = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
    	tiempo = tiempo + Time.deltaTime;
    	segundos = (int) tiempo;
    	GetComponent<TextMesh>().text = "Tiempo:\n " + segundos;        
    }
}
