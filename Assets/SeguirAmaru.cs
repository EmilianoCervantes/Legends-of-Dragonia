using UnityEngine;
using System.Collections;

public class SeguirAmaru : MonoBehaviour {
	public Transform personaje;
	public float distanciaentreCamara;

	void Update () {
		if((personaje.position.x < 255.0f) && (personaje.position.x > -33.0f )){ 
			transform.position = new Vector3 (personaje.position.x+distanciaentreCamara, 
				0.5f,transform.position.z);
		}
		if((personaje.position.y < 255.0f) && (personaje.position.y > -33.0f )){ 
			transform.position = new Vector3 (personaje.position.x+distanciaentreCamara,personaje.position.y+distanciaentreCamara, 
				transform.position.z);
		}
	}
}
