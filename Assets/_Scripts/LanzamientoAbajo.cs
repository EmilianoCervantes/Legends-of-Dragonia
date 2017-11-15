using UnityEngine;
using System.Collections;

public class LanzamientoAbajo : MonoBehaviour {

	public float velocidadLanzamiento;
	float rotationDelDisparador;
	public DispararFlechas disparador;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		//derecha
		transform.Translate (new Vector3 (0, velocidadLanzamiento*-1, 0));
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}