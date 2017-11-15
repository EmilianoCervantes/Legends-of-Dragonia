using UnityEngine;
using System.Collections;

public class Lanzamiento : MonoBehaviour {

	public float velocidadLanzamiento;
	float rotationDelDisparador;
	public DispararFlechas disparador;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (velocidadLanzamiento, 0, 0));
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}