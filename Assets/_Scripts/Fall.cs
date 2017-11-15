using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour{ //se le asigna al jugador
	// Use this for initialization
	void Start(){
		VariablesDelJuego.checkpoint = new Vector2(transform.position.x,transform.position.y); //aqui ponen las coordenadas de donde empieza el personaje al inicio
	}

	// Update is called once per frame
	void Update(){
		if(transform.position.y < -15){ //si su posicion es menor a -100, lo regresa a la del checkpoint
			transform.position= VariablesDelJuego.checkpoint;
		}
	}
}
