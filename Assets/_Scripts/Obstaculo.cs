using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {
	
	float tiempo = 0f;
	//float tiempoMax=1f;
	public float danoAtaque;
	public float ritmoAtq;
	public float lanzarAtras;

	void Start () {
		tiempo = 0f;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D o){
		if (o.tag == "player" && tiempo < Time.time) {
			SaludJugador jugador = o.gameObject.GetComponent<SaludJugador> ();
			jugador.ChecarSalud (danoAtaque);
			tiempo = Time.time + ritmoAtq;
			lanzar (o.transform);
		}
		if (o.gameObject.tag== "BolaDeFuego") {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){

	}

	void lanzar(Transform oTrans){
		Vector2 direccion = new Vector2 (0,oTrans.position.y - transform.position.y).normalized;
		direccion *= lanzarAtras;
		Rigidbody2D lanzarRB = oTrans.gameObject.GetComponent<Rigidbody2D> ();
		lanzarRB.velocity = Vector2.zero;
		lanzarRB.AddForce (direccion, ForceMode2D.Impulse);
	}
}