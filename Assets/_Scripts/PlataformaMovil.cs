using UnityEngine;
using System.Collections;

public class PlataformaMovil : MonoBehaviour {
	
	/*public GameObject inicio;
	public GameObject fin;
	public bool vertical;
	
	// Use this for initialization
	void Start () {
		
		if (vertical) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 4.0f);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (4.0f, 0f);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (vertical) {
			
			if (gameObject.transform.position.y > fin.transform.position.y) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2(0f, -4.0f);
			}
			
			if (transform.position.y < inicio.transform.position.y) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2(0f, 4.0f);
			}
		}
		
		if(!vertical){
			
			if (transform.position.x > fin.transform.position.x) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2(-4.0f, 0f);
				
				GameObject personaje = GameObject.FindGameObjectWithTag("Personaje");
				if(name == "AutoMobile" && Mathf.Abs(transform.position.x - personaje.transform.position.x) < 8.0f){
					GetComponent<AudioSource> ().Play ();
				}
			}
			
			if (transform.position.x < inicio.transform.position.x) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2(4.0f, 0f);
				
				GameObject personaje = GameObject.FindGameObjectWithTag("Personaje");
				if(name == "AutoMobile" && Mathf.Abs(transform.position.x - personaje.transform.position.x) < 8.0f){
					GetComponent<AudioSource> ().Play ();
				}
			}
		}
	}*/
}