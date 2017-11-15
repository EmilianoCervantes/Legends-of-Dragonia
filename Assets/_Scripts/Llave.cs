using UnityEngine;
using System.Collections;

public class Llave : MonoBehaviour {
	public string h;
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.name=="amaru inicial"){
			MovimientoProtagonista.fli = true;
			GameObject g = GameObject.Find (h);
			Destroy (g);

			Invoke ("destruir", 1f);
		}

	}

	void destruir(){
		Destroy (gameObject);
	}

		}
 

//se le pone a un objeto en el juego y tiene que tener en su collider activado el cuadro de isTrigger