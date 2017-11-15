using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.name=="amaru inicial"){

			//si el personaje toca el GameObject al que se le pone este cÛdigo, se actualiza el checkpoint
			VariablesDelJuego.checkpoint = transform.position;
			gameObject.GetComponent<AudioSource> ().Play ();
		
			Invoke ("destruir", 1f);
		}

	}
	void destruir(){
		Destroy (gameObject);
	}
} 

//se le pone a un objeto en el juego y tiene que tener en su collider activado el cuadro de isTrigger