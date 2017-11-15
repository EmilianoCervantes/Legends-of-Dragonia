using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaludVillanos : MonoBehaviour {
	public float saludMax = 20f;
	float nuevaSalud;
	bool items = true;
	public GameObject itemPickUp;

	public Slider enemSlider;

	// Use this for initialization
	void Start () {
		nuevaSalud = saludMax;
		enemSlider.maxValue = nuevaSalud;
		enemSlider.value = nuevaSalud;
	}

	/*public void OnGUI(){
		
	}*/

	public void ChecarSalud(float cambios){
		enemSlider.gameObject.SetActive (true);
		nuevaSalud -= cambios;
		enemSlider.value = nuevaSalud;
		//Si pierde vida, que no baje del nivel "normal"
		if(nuevaSalud<=0){
			nuevaSalud = 0;
			matar ();
		}
		//Si recupera vida, que no se pase del máximo
		if(nuevaSalud>saludMax){
			nuevaSalud = saludMax;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	void matar(){
		if (items) {
			Instantiate (itemPickUp, transform.position, Quaternion.identity);
		}
		Destroy (gameObject);
	}
}