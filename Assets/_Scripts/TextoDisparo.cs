using UnityEngine;
using System.Collections;

public class TextoDisparo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (DisparoJugador.ataque == true) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			GameObject g = GameObject.Find ("FichaDisparo");
			Destroy (g);
			Invoke ("Destruir", 4);
		}
	}

	void Destruir(){
		
		Destroy (gameObject);


	}
}
