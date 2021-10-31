using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
	float speed, amount, x, y, z, vuelta, tiempo, contador;
	Vector3 nuevo, inicial;
	AudioSource audio;
    // Start is called before the first frame update
	void Start()
	{

		audio = GetComponent<AudioSource>();
        speed = 1.0f; //how fast it shakes
	amount = 1.0f; //how much it shakes
	inicial = transform.position;
	x = inicial.x;
	y = inicial.y;
	z = inicial.z;
	nuevo = new Vector3 ((x+0.2f), y, z);
}


    // Update is called once per frame
void Update()
{
	if (Input.GetKeyDown(KeyCode.Space) ||Input.GetKeyDown(KeyCode.JoystickButton3) && contador<= 0)  {

		audio.Play();

		transform.position =  nuevo;
		contador = 4;
		

	}

	if (tiempo >= 0.1f)  {

			transform.position  =  inicial;
			tiempo = 0;

		}

		contador = contador - Time.deltaTime;
		tiempo = tiempo+ Time.deltaTime;

}
}