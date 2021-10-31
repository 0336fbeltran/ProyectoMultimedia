using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 50f;
    public float hitStrenght = 999999999f;
    public float flipperDamper = 15000f;
     private bool seUsa = false;
AudioSource audio;
    HingeJoint hinge;
    public string inputName;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }
    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
          
        if (Input.GetAxis(inputName) == 1)
        {
            if (seUsa == false) { // Hace que el sonido suene desde que se pulsa la letra
                audio.Play();
                seUsa = true;
            }
           
            spring.targetPosition = pressedPosition;
        }
        else
        {
            seUsa = false;
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}