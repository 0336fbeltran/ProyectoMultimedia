using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitSonido : MonoBehaviour
{
    public static AudioSource sonidoDeFondo;
    // Start is called before the first frame update
    void Start()
    {
        sonidoDeFondo = GetComponent <AudioSource>();
        sonidoDeFondo.Play();
    }

    // Update is called once per frame
    public void Quitar()
    {
        sonidoDeFondo.Stop();
    }
    public void Poner()
    {
        sonidoDeFondo.Play();
    }
}
