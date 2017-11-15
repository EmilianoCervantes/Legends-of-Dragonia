using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaludJugador : MonoBehaviour {
	public float saludMax = 30f;
	public float nuevaSalud;
	public static bool vulnerable=true;

	//control de movimientos
	Protagonista controlMov;

	//Variables de cámara jugador
	public Slider saludSlid;

	// Use this for initialization
	void Start () {
		nuevaSalud = saludMax;
		//Serán corazones
		controlMov = GetComponent<Protagonista> ();

		//unir barra de vida y variable
		saludSlid.maxValue = saludMax;
		saludSlid.value = saludMax;
	}

	/*public void OnGUI(){
		Corazones
		GUI.Box (new Rect (150, Screen.height-50, Corazones, 20),nuevaSalud+"/"+saludMax);
		if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
			print("You clicked the button!");
	}*/

	public void ChecarSalud(float cambios){
		if (cambios <= 0) {
			nuevaSalud += cambios;
			saludSlid.value = nuevaSalud;
		} else if(vulnerable&&cambios >0){
			nuevaSalud -= cambios;
			saludSlid.value = nuevaSalud;
		}

		//Si pierde vida, que no baje del nivel "normal"
		if(nuevaSalud<0){
			nuevaSalud = 0;
			matar ();
		}
		//Si recupera vida, que no se pase del máximo
		if(nuevaSalud>saludMax){
			nuevaSalud = saludMax;
			saludSlid.value = nuevaSalud;
		}

	}


	void Update () {
		ChecarSalud (nuevaSalud);
		if (nuevaSalud == 0) {
			matar ();
			//Mandar a punto de control
		}
	}
	public void matar(){
		//animaciones
		//muertes por caer
		//Instantiate(efectosMuerte,transform.position,transform.rotation);
		Destroy (gameObject);
	}
}