using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrarPuerta : MonoBehaviour
{
	GameObject bola, puerta;
	Vector3 inicial, final;
	float x, y, z, tiempo, velocidad;
	bool cerrada;

	Collider collider1;
	Collider collider2;
    // Start is called before the first frame update
	void Start()
	{
		bola = GameObject.Find("Bola");
		puerta = GameObject.Find("Puerta");
		inicial = transform.position;
		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;
		cerrada = false;
		final = new Vector3(2.48645353f,0.26699999f,5.23699999f);

		collider1 = GameObject.Find("Puerta").GetComponent<BoxCollider>();
		collider2 = GameObject.Find("Cube").GetComponent<BoxCollider>();
	}

    // Update is called once per frame
	void Update()
	{
		Debug.Log(bola.transform.position.x);
		Physics.IgnoreCollision(collider1, collider2, true);

		if (bola.transform.position.x < 2.38f && cerrada == false) {
			puerta.transform.position = Vector3.MoveTowards(inicial, final, tiempo / 0.1f);
			tiempo = tiempo + Time.deltaTime;
			if (tiempo>1f) {
				tiempo = 0;   		 
				cerrada = true;
			}
			}

			if (bola.transform.position.x > 2.60f && cerrada ==true) {
				puerta.transform.position = Vector3.MoveTowards(final, inicial, tiempo / 0.1f);
				tiempo = tiempo + Time.deltaTime;
				if (tiempo>1f) {
				tiempo = 0;   		 
				cerrada = false;
			}
			}
		}
	}
