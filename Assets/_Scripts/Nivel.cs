using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Nivel : MonoBehaviour {
	public int nivel;

	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag=="Fin"){
			VariablesDelJuego.nivel = 1;
			Application.LoadLevel("Nivel2");
			Application.LoadLevel(nivel);
		}
	}
}
