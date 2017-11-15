using UnityEngine;
using System.Collections;

public class TextoNivelTres : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
	}
	
	void Update () {
		if (MovimientoProtagonista.poderActivado == true) {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			MovimientoProtagonista.fli = true;
			GameObject g = GameObject.Find ("fichaPoder3");
			Destroy (g);
			Invoke ("Destruir", 4);
		}
	}
	
	void Destruir(){
		
		Destroy (gameObject);
		
		
	}
}
