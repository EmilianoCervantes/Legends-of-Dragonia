using UnityEngine;
using System.Collections;

public class MovimientoDisparo : MonoBehaviour {
	
	public float velocidadLanzamiento;
	int direccionDeDisparo;
	// Use this for initialization
	void Start () {
		direccionDeDisparo = MovimientoProtagonista.direccion;
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2(velocidadLanzamiento*direccionDeDisparo,0));
	}
	
	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
