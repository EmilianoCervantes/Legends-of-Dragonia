using UnityEngine;
using System.Collections;

public class Protagonista : MonoBehaviour {

	public float speed = 8f;
	private float groundRad = 0.2f;
	private bool Right = true;
	private bool onGround = false;
	private Animator anim;
	public Transform CheckGround;
	public LayerMask identGround;
	//public int vida = 3;

	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// FixUpdate is called once per frame
	//Se utiliza en vez de Update ya que hacemos manipulaciones físicas con los obj
	void FixUpdate () {
		//eje vertical
		onGround = Physics2D.OverlapCircle (CheckGround.position, groundRad, identGround);
		anim.SetBool ("Ground", onGround);
		anim.SetFloat ("Speed", gameObject.GetComponent<Rigidbody2D>().velocity.y);

		//eje horizontal
		float mover = Input.GetAxis ("Horizontal");
		Rigidbody2D rb2D = gameObject.GetComponent<Rigidbody2D> ();

		//modificar speed con valor absoluto de mover
		anim.SetFloat("Speed", Mathf.Abs(mover));

		//hacer movimiento
		rb2D.velocity = new Vector2(mover*speed, rb2D.velocity.y);

		//girar
		if(mover > 0 && !Right){
			Girar ();
		}else if(mover < 0 && Right){
			Girar();
		}
	}

	public float Salto = 400;
	public void Update(){
		if(onGround && Input.GetKeyDown (KeyCode.Space)){
			anim.SetBool ("Ground", false);
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(0,Salto));
		}

		/*if(Input.GetKeyDown (KeyCode.Keypad1)){
			anim.SetBool ("Golpear", true);
			Golpear ();
		}

		if(Input.GetKeyDown (KeyCode.Keypad2)){
			anim.SetBool ("Golpear", true);
			Patear ();
		}

		if(Input.GetKeyDown (KeyCode.Keypad3)){
			anim.SetBool ("Golpear", true);
			Patear ();
		}*/
	}

	public void Girar(){
		Right = !Right;

		//Invertimos eje x, es decir, su escala
		//se tiene que hacer una línea por cada cosa, no se puede poner junto
		Vector3 escalaPers = gameObject.transform.localScale;
		escalaPers.x *= -1;
		gameObject.transform.localScale = escalaPers;
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			SaludVillanos bajar = other.gameObject.GetComponent<SaludVillanos> ();
			bajar.ChecarSalud (10);
		}
	}
}