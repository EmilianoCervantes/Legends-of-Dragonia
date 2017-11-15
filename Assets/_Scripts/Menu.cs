using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	
	public Canvas cSalida;
	public Canvas cInstrucciones;
	public Button bJugar;
	public Button bInst;
	public Button bSalir;

	void Start () {
		cSalida = cSalida.GetComponent<Canvas> ();
		cInstrucciones = cInstrucciones.GetComponent<Canvas> ();
		bJugar = bJugar.GetComponent<Button> ();
		bInst = bInst.GetComponent<Button> ();
		bSalir = bSalir.GetComponent<Button> ();
		cSalida.enabled = false;
		cInstrucciones.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Jugar(){
		//cargar la escena indicada, ej: First Level
		//obsoleto:
		Application.LoadLevel("Nivel1");
	}

	public void Instrucciones(){
		cInstrucciones.enabled = true;
		cSalida.enabled = false;
		bJugar.enabled = false;
		bInst.enabled = false;
		bSalir.enabled = false;
	}

	public void RegresarInst(){
		cInstrucciones.enabled = false;
		cSalida.enabled = false;
		bJugar.enabled = true;
		bInst.enabled = true;
		bSalir.enabled = true;
	}

	public void menuSalir(){
		cSalida.enabled = true;
		cInstrucciones.enabled = false;
		bJugar.enabled = false;
		bInst.enabled = false;
		bSalir.enabled = false;
	}

	public void NoSalir(){
		cSalida.enabled = false;
		cInstrucciones.enabled = false;
		bJugar.enabled = true;
		bInst.enabled = true;
		bSalir.enabled = true;
	}

	public void Salir(){
		/* #if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else 
		Application.Quit(); --> SceneManager.QuitScene("SceneName");
		#endif*/

		Application.Quit ();
	}
}