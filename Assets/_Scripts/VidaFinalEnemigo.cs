using UnityEngine;
using System.Collections;

public class VidaFinalEnemigo : MonoBehaviour {
	int contador;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (contador > 10) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "BolaDeFuego") {
			contador = contador + 1;
		}
	}
}
