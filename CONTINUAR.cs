using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTINUAR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Musica").GetComponent<MUSICA>().PlayMusic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
