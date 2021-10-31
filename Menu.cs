using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	AudioSource audio;
void Start() {
		audio = GameObject.Find("sonido").GetComponent<AudioSource>();
}
void Update() {
    if (Input.GetKeyUp(KeyCode.JoystickButton0))
    startGame();
     if (Input.GetKeyUp(KeyCode.JoystickButton3))
     exit();
}
    public void startGame() {  
    	audio.Play();
        Debug.Log("Empezar Juego");
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
    	audio.Play();
        Debug.Log("Salir del juego");
        Application.Quit();
    }
    public void volver()
    {
    	audio.Play();
        Debug.Log("Volver al juego");
        SceneManager.LoadScene(1); 
    }
  
}
