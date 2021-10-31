using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignorar : MonoBehaviour
{
    Collider collider1;
    Collider collider2;
    // Start is called before the first frame update
    void Start()
    {
        collider1 = GameObject.Find("Pipe").GetComponent<MeshCollider>();
        collider2 = GameObject.Find("Trigger").GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreCollision(collider1, collider2, true);
    }


}
