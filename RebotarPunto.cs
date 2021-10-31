using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebotarPunto : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Just for debugging, adds some velocity during OnEnable")]
    private Vector3 initialVelocity;

    [SerializeField]
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag =="Rebotador") // La bola rebotara con todos los objetos con este tag
        Bounce(collision.contacts[0].normal);
        if(collision.collider.tag == "Pared")
            Pared(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        //var speed = lastFrameVelocity.magnitude;
        var speed = 20f; // Cambiamos la velocidad de rebote con esto 
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
    private void Pared(Vector3 collisionNormal)
    {
        //var speed = lastFrameVelocity.magnitude;
        var speed = 10f; // Cambiamos la velocidad de rebote con esto 
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}