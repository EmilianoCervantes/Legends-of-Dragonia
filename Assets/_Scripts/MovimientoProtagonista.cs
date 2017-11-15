using UnityEngine;
using System.Collections;

public class MovimientoProtagonista : MonoBehaviour {

	public static bool fli=false;
	private bool isJumping = false;
	private bool isJumping2 = false;
	public static bool poderActivado = false;
	// Use this for initialization
	void Start () {

	}

	public float MaxSpeed = 10f;
	public float altura;
	private bool _facingRight = true;

	public static int direccion = 1;

	void FixedUpdate () {

		fly ();
		float move = Input.GetAxis("Horizontal");
		// Obtenemos el componente Rigidbody 2D del objeto
		Rigidbody2D r2d = gameObject.GetComponent<Rigidbody2D>();

		jump ();
		r2d.velocity = new Vector2(move * MaxSpeed, r2d.velocity.y);


		if (move > 0 && !_facingRight) {
			Flip();
			direccion = 1;
		} else if (move < 0 && _facingRight) {
			Flip();
			direccion = -1;
		}
	}
	void fly() {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			if (fli != false) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * altura);
			}
		}
	}
	void jump() {

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (isJumping == false) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * altura);
				isJumping = true;
			} else if (!isJumping2) {
				gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * altura);
				isJumping2 = true;
			}

		}
	}

	//this bit is to check if the object that collided with it has the ground tag
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Ground") {
			isJumping = false;
			isJumping2 = false;
		}else if(col.gameObject.name=="fichaPoder3"){
			poderActivado = true;
			PoderTresActivado ();
		}
	}

	void Flip() {
		// Hacemos el giro en la lógica del juego
		_facingRight = !_facingRight;
		// Invertimos su escala en el eje de las x
		Vector3 myScale = gameObject.transform.localScale;
		myScale.x *= -1;
		// Asignamos la nueva escala al personaje
		gameObject.transform.localScale = myScale;
	}
	void PoderTresActivado (){
		if(poderActivado && Input.GetKeyDown(KeyCode.I)){
			MaxSpeed = MaxSpeed * 2.5f;
			SaludJugador.vulnerable = false;
			Invoke ("PoderTresDesactivado", 5);
		}
	}
	void PoderTresDesactivado (){
		if(poderActivado && Input.GetKeyDown(KeyCode.I)){
			MaxSpeed = MaxSpeed / 2.5f;
			SaludJugador.vulnerable = true;
			poderActivado = false;
			Invoke ("ActivarPoder", 20);
		}
	}
	void ActivarPoder (){
		poderActivado = true;
	}
	void Update(){
		PoderTresActivado ();
	}

}