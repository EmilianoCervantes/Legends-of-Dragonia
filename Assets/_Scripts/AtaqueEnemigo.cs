using UnityEngine;
using System.Collections;

public class AtaqueEnemigo : MonoBehaviour {

	//velocidad del enemigo
	public float velocidad;

	//falta animacion del enemigo

	public GameObject enemigo;

	//girar
	bool gira = true;
	bool Izquierda = true;
	float tiempoGirar = 10f;
	float limiteGirar = 0f;

	public float tiempoAtaque;
	float iniciaAtaque;
	bool atacando=false;
	Rigidbody2D rbEnemigo;

	void Start () {
		rbEnemigo = GetComponent <Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > limiteGirar) {
			if (Random.Range (0, 10) >= 5) {
				Girar ();
			}
			limiteGirar = Time.time + tiempoGirar;
		}
	}

	void Girar(){
		if (!gira) {
			//nada
		} else {
			//El enemigo sólo puede girar, no saltar o volar
			float girarEnX = enemigo.transform.localScale.x;
			girarEnX *= -1f;
			enemigo.transform.localScale = new Vector3 (girarEnX, enemigo.transform.localScale.y, enemigo.transform.localScale.z);
			Izquierda = !Izquierda;
		}
	}

	void OnTriggerEnter2D(Collider2D col2D){
		if (col2D.tag == "Player") {
			if (!Izquierda && (col2D.transform.position.x < transform.position.x)) {
				Girar ();
			} else if(Izquierda && (col2D.transform.position.x > transform.position.x)) {
				Girar ();
			}
			gira = false;
			atacando = true;
			iniciaAtaque = Time.time + tiempoAtaque;
		}
	}

	void OnTriggerStay2D(Collider2D col2D){
		if (col2D.tag == "Player") {
			if (iniciaAtaque < Time.time) {
				if (Izquierda) {
					rbEnemigo.AddForce (new Vector2 (-1, 0) * velocidad);
				} else {
					rbEnemigo.AddForce (new Vector2 (-1, 0) * velocidad);
				}
				///animacion de ataque -->
				/// Animator.SetBool("atacando",atacando);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col2D){
		if (col2D.tag == "Player") {
			gira = true;
			atacando = false;
			rbEnemigo.velocity = new Vector2 (0f, 0f);
			//cambiar animacion SetBool("atacando",atacando);
		}
	}

	///notas:
	/// En Inspector --> RB -->Linear Drag
	/// se utiliza para que se vaya reduciendo la velocidad hasta parar
}