using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuSecundario : MonoBehaviour {

	public Canvas cPausa;
	public Button bRegresar;
	public Button bMenuPrincipal;
	public Button bSalir;

	void Start () {
		cPausa = cPausa.GetComponent<Canvas> ();
		bSalir = bSalir.GetComponent<Button> ();
		bRegresar = bRegresar.GetComponent<Button> ();
		cPausa.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Pausa ();
		}
		if(Input.GetKeyDown (KeyCode.Pause)){
			Pausa ();
		}
	}

	public void Pausa(){
		cPausa.enabled = !cPausa.enabled;
		bRegresar.enabled = true;
		bMenuPrincipal.enabled = true;
		bSalir.enabled = true;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		/*if (Input.GetKeyDown (KeyCode.S)) {
			SceneManager.LoadScene ("Menu");
		}*/
	}

	public void Regresar(){
		cPausa.enabled = false;
		bRegresar.enabled = false;
		bMenuPrincipal.enabled = false;
		bSalir.enabled = false;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}

	public void Salir(){
		Application.Quit ();
	}

	public void MenuPrincipal(){
		Application.LoadLevel ("Menu");
	}
}