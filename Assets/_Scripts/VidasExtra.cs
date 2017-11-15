using UnityEngine;
using System.Collections;

public class VidasExtra : MonoBehaviour {
	//vidas extra son negativas, sino bajan salud
	public float vidaExtra = -5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D o){
		if (o.tag == "Player") {
			SaludJugador salud = o.gameObject.GetComponent<SaludJugador> ();
			salud.ChecarSalud (vidaExtra);
			Destroy (gameObject);
		}
	}
}
