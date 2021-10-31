using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
	AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
           	audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnCollisionEnter(Collision objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.collider.name == "Bola")
        {
        	audio.Play();

        }
    }
}
