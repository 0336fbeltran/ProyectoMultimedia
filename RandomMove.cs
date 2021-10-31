using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public Vector3 inicial;
    public Vector3 nuevo;
    // Start is called before the first frame update
    void Start()
    {
        inicial = transform.position;

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter(Collision objetoQueHaEntrado)
    {
        if (objetoQueHaEntrado.collider.name == "Bola")
        {
            nuevo = new Vector3(Random.Range(-1.75f, 1.80f), 0.46f, Random.Range(-4.08f, 5.73f));
            transform.position = nuevo;
        }
    }
}
